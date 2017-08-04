using System;
using System.IO;
using System.IO.Ports;
using System.Text;

namespace ELM327SWDL
{
    public class ELM327Serial
    {

        #region Data
        public SerialPort mySerialPort = new SerialPort();
        public string cPort { get; protected set; } = "COM41";
        public int bRate { get; protected set; } = 38400;
        public int dBits { get; protected set; } = 8;
        public Parity Parity { get; protected set; } = Parity.None;
        public StopBits StopBits { get; protected set; } = StopBits.One;
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
        public bool openPort()
        {
            mySerialPort.PortName = cPort;
            mySerialPort.BaudRate = bRate;
            mySerialPort.DataBits = dBits;
            mySerialPort.Parity = Parity;
            mySerialPort.StopBits = StopBits;
            mySerialPort.Handshake = Handshake.RequestToSendXOnXOff;
            mySerialPort.ReadTimeout = 5000;
            mySerialPort.WriteTimeout = 5000;

            try
            {
                mySerialPort.Open();
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

        public bool testELM327Port()
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
                        x = mySerialPort.ReadExisting();
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
                mySerialPort.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion Connection

        #region Command
        public string sendCommand(ATCommand command, string Data = "")
        {
            try
            {
                mySerialPort.WriteLine(command.Command + Data + "\r\n");
                string output = mySerialPort.ReadExisting();
                return output;
            }
            catch
            {
                return "failed\r\n";
            }
        }
        #endregion Command

        #region SetFunctions
        public bool SetComPort(string comPort)
        {
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close();
            }
            if (comPort != "")
            {
                mySerialPort.PortName = comPort;
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
                    x = mySerialPort.ReadExisting();
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