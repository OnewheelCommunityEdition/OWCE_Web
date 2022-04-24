using System;
namespace OWCE_Web.Data
{
    public enum FirmwareStatus
    {
        Unknown,
        Suspected,
        ConfirmedNotPubliclyAvailable,
        Confirmed,
    }

    public class Board
    {
        public string Name { get; init; }
        public string Description { get; init; }
        public List<int> KnownHardware { get; } = new List<int>();
        public List<int> KnownFirmware { get; } = new List<int>();
        public Dictionary<(int, int), FirmwareStatus> KnownHardwareFirmware { get; } = new Dictionary<(int, int), FirmwareStatus>();

        private Board(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public static Board GetV1()
        {
            var board = new Board("V1", "The original board which started off as a kickstarter on January 7th 2014. The initial kickstarter boards started shipping April 4th 2015. This board would later be discontinued in favour of the Onewheel Plus");

            board.KnownHardware.Add(1206);
            board.KnownHardware.Add(2206);

            board.KnownFirmware.Add(3034);
            board.KnownFirmware.Add(3040);
            board.KnownFirmware.Add(3056);

            board.KnownHardwareFirmware.Add((1206, 3056), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((2206, 3034), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((2206, 3040), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((2206, 3056), FirmwareStatus.Confirmed);

            return board;
        }

        public static Board GetPlus()
        {
            var board = new Board("Plus", "Onewheel Plus was announced at CES 2017.");

            board.KnownHardware.Add(3206);
            board.KnownHardware.Add(3208);

            board.KnownFirmware.Add(4000);
            board.KnownFirmware.Add(4001);
            board.KnownFirmware.Add(4020);
            board.KnownFirmware.Add(4027);
            board.KnownFirmware.Add(4031);
            board.KnownFirmware.Add(4034);

            board.KnownHardwareFirmware.Add((3206, 4000), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((3206, 4001), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((3206, 4020), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((3206, 4034), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((3208, 4031), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((3208, 4034), FirmwareStatus.Confirmed);

            return board;
        }

        public static Board GetXR()
        {
            var board = new Board("XR", "Onewheel+ XR was announced at CES 2018.");

            board.KnownHardware.Add(4206);
            board.KnownHardware.Add(4208);
            board.KnownHardware.Add(4209);
            board.KnownHardware.Add(4210);
            board.KnownHardware.Add(4211);
            board.KnownHardware.Add(4212);
            board.KnownHardware.Add(4213);

            board.KnownFirmware.Add(4107);
            board.KnownFirmware.Add(4117);
            board.KnownFirmware.Add(4134);
            board.KnownFirmware.Add(4142);
            board.KnownFirmware.Add(4144);
            board.KnownFirmware.Add(4150);
            board.KnownFirmware.Add(4152);
            board.KnownFirmware.Add(4155);
            board.KnownFirmware.Add(4161);
            board.KnownFirmware.Add(4162);

            board.KnownHardwareFirmware.Add((4206, 4107), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4206, 4134), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4208, 4117), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4208, 4134), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4209, 4134), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4209, 4150), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4209, 4152), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4210, 4142), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4210, 4144), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4210, 4150), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4211, 4150), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((4212, 4152), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4212, 4155), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4212, 4161), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((4213, 4162), FirmwareStatus.ConfirmedNotPubliclyAvailable);

            return board;
        }


        public static Board GetPint()
        {
            var board = new Board("Pint", "Onewheel Pint was announced March 13th 2019 at a small event in New York");

            board.KnownHardware.Add(5300);
            board.KnownHardware.Add(5301);
            board.KnownHardware.Add(5302);
            board.KnownHardware.Add(5314);
            board.KnownHardware.Add(5315);

            board.KnownFirmware.Add(5040);
            board.KnownFirmware.Add(5042);
            board.KnownFirmware.Add(5046);
            board.KnownFirmware.Add(5050);
            board.KnownFirmware.Add(5059);
            board.KnownFirmware.Add(5069);

            board.KnownHardwareFirmware.Add((5300, 5040), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5300, 5042), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5301, 5042), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5301, 5046), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5301, 5050), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5302, 5050), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5314, 5050), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5314, 5059), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((5314, 5069), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((5315, 5050), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((5315, 5059), FirmwareStatus.Suspected);
            board.KnownHardwareFirmware.Add((5315, 5069), FirmwareStatus.Suspected);


            return board;
        }

        public static Board GetPintX()
        {
            var board = new Board("Pint X", "Onewheel Pint X was announced October 27th 2021.");

            board.KnownHardware.Add(7314);

            board.KnownFirmware.Add(5076);

            board.KnownHardwareFirmware.Add((7314, 5076), FirmwareStatus.Confirmed);
            return board;
        }


        public static Board GetGT()
        {
            var board = new Board("GT", "Onewheel GT was announced at the same time as the Pint X on October 27th 2021, however it did not start shipping until March of 2022.");

            board.KnownHardware.Add(6400);
            board.KnownHardware.Add(6404);
            board.KnownFirmware.Add(6064);
            board.KnownFirmware.Add(6069);
            board.KnownFirmware.Add(6070);
            board.KnownFirmware.Add(6071);
            board.KnownFirmware.Add(6100);

            board.KnownHardwareFirmware.Add((6400, 6064), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((6404, 6064), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((6404, 6069), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((6404, 6070), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((6404, 6071), FirmwareStatus.ConfirmedNotPubliclyAvailable);
            board.KnownHardwareFirmware.Add((6400, 6100), FirmwareStatus.Confirmed);
            board.KnownHardwareFirmware.Add((6404, 6100), FirmwareStatus.Confirmed);

            return board;
        }
    }
}

