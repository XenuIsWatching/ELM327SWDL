using System;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace ELM327SWDL
{
    public class ELM327Serial
    {
        #region Data
        public SerialPort elmSerialPort = new SerialPort();
        public string cPort { get; protected set; } = "COM41";
        public int bRate { get; protected set; } = 38400;
        public int dBits { get; protected set; } = 8;
        public Parity Parity { get; protected set; } = Parity.None;
        public StopBits StopBits { get; protected set; } = StopBits.One;
        public elm327form FormReference;

        #endregion Data

        #region Constuctor

        //Add Default Constructors for derived classes
        //for setting default data property values-no input values
        public ELM327Serial()
        {

        }
        //Add Instance Constructors for derived classes
        //for setting data property values-takes input values
        public ELM327Serial(string comPort, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            cPort = comPort;
            bRate = baudRate;
            Parity = parity;
            dBits = dataBits;
            StopBits = stopBits;
        }
        #endregion Constructors

        #region Connection
        public bool openPort(elm327form formReference)
        {
            elmSerialPort.PortName = cPort;
            elmSerialPort.BaudRate = bRate;
            elmSerialPort.DataBits = dBits;
            elmSerialPort.Parity = Parity;
            elmSerialPort.StopBits = StopBits;
            elmSerialPort.Handshake = Handshake.RequestToSendXOnXOff;
            elmSerialPort.ReadTimeout = 5000;
            elmSerialPort.WriteTimeout = 5000;
            elmSerialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataRecieved);
            FormReference = formReference;

            try
            {
                elmSerialPort.Open();
                bool success = testELM327Port();
                if (!success)
                {
                    return false;
                }
                Console.WriteLine("Port Opened!!");
                return true;
            }
            catch
            {
                Console.WriteLine("Port Not Opened!!");
                return false;
            }
        }

        private void port_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            string data = elmSerialPort.ReadExisting();

            Action toBeRunOnGuiThread = () => FormReference.writeToConsoleBox(data);

            // to guard yourself from all evil
            // you could check to see if it is needed to
            if (FormReference.InvokeRequired)
                // marshal the call to the action all the way to the GUI thread
                FormReference.Invoke(toBeRunOnGuiThread);
            else
                // or, if we ARE on the GUI thread already, just call it from this thread
                toBeRunOnGuiThread();
        }

        private bool testELM327Port()
        {
            int timeout = 100;
            try
            {
                sendCommand(ATCommand.PrintVersion);
                StringBuilder response = new StringBuilder();
                string x = "";
                try
                {
                    while (timeout > 0 && !response.ToString().Contains(ATCommand.PrintVersion.ExpectedResult))
                    {
                        x = elmSerialPort.ReadExisting();
                        response = response.Append(x);
                        timeout--;
                    }
                    if (timeout == 0)
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool closePort()
        {
            try
            {
                elmSerialPort.Close();
                elmSerialPort.DataReceived -= new SerialDataReceivedEventHandler(port_DataRecieved);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion Connection

        #region Command
        public bool sendCommand(ATCommand command, string Data = "")
        {
            try
            {
                elmSerialPort.WriteLine(command.Command + Data + "\r");
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool sendCommand(string Data)
        {
            try
            {
                elmSerialPort.WriteLine(Data + "\r");
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion Command

        #region SetFunctions
        public bool SetComPort(string comPort)
        {
            if (elmSerialPort.IsOpen)
            {
                elmSerialPort.Close();
            }
            if (comPort != "")
            {
                elmSerialPort.PortName = comPort;
                cPort = comPort;
                return true;
            }
            else
            {
                return false;
            }
        }
        

        #endregion SetFunctions

        #region ReceiveResponse
        /// <summary>
        /// The robot responds with 'ok!' after every command
        /// When the robot is 'homed' it responds with an 'ok!' after it has 'homed'
        /// This function is added to all the movement functions to ensure the response is received
        /// </summary>
        public bool waitForELM327Response()
        {
            StringBuilder response = new StringBuilder();
            string x = "";
            try
            {
                while (!response.ToString().Contains("OK"))
                {
                    x = elmSerialPort.ReadExisting();
                    response = response.Append(x);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion ReceiveResponse
    }
}