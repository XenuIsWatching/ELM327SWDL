﻿namespace ELM327SWDL
{
    public class ATCommand
    {
        #region Values

        public static readonly ATCommand RepeatLastCommand = new ATCommand("\r");
        public static readonly ATCommand ResetDevice = new ATCommand("ATZ");
        public static readonly ATCommand ReadVoltage = new ATCommand("ATRV");
        public static readonly ATCommand EchoOn = new ATCommand("ATE1", "OK");
        public static readonly ATCommand EchoOff = new ATCommand("ATE0", "OK");
        public static readonly ATCommand HeadersOn = new ATCommand("ATH1", "OK");
        public static readonly ATCommand HeadersOff = new ATCommand("ATH0", "OK");
        public static readonly ATCommand PrintSpacesOn = new ATCommand("ATS1", "OK");
        public static readonly ATCommand PrintSpacesOff = new ATCommand("ATS0", "OK");
        public static readonly ATCommand LinefeedsOn = new ATCommand("ATL1", "OK");
        public static readonly ATCommand LinefeedsOff = new ATCommand("ATL0", "OK");
        public static readonly ATCommand SetProtocolAuto = new ATCommand("ATSP0", "OK");
        public static readonly ATCommand PrintVersion = new ATCommand("ATI", "ELM327");
        public static readonly ATCommand CloseProtocol = new ATCommand("ATPC");
        public static readonly ATCommand DeviceDescription = new ATCommand("AT@1");
        public static readonly ATCommand DeviceIdentifier = new ATCommand("AT@2");
        public static readonly ATCommand LowPowerMode = new ATCommand("ATLP");
        public static readonly ATCommand SetProtocol = new ATCommand("ATSP", "OK");
        public static readonly ATCommand StoreData = new ATCommand("ATSD", "OK");
        public static readonly ATCommand ReadData = new ATCommand("ATRD");
        public static readonly ATCommand ReadProtocol = new ATCommand("ATDP");
        public static readonly ATCommand Set11BitHeader = new ATCommand("ATSH","OK");
        public static readonly ATCommand MonitorAll = new ATCommand("ATMA", "OK");
        public static readonly ATCommand MonitorTx = new ATCommand("ATMT", "OK");
        public static readonly ATCommand MonitorRx = new ATCommand("ATMR", "OK");
        public static readonly ATCommand Default = new ATCommand("ATD", "OK");

        #endregion

        #region Properties & Fields

        public string Command { get; }
        public string ExpectedResult { get; }

        #endregion

        #region Constructors

        private ATCommand(string command, string expectedResult = null)
        {
            this.Command = command;
            this.ExpectedResult = expectedResult;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return Command;
        }

        #endregion

        #region Operators

        public static implicit operator string(ATCommand command)
        {
            return command.ToString();
        }

        #endregion
    }
}
