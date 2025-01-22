using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace QuanLyCLB.Exif
{
    public class ConversionConstants
    {
        public Dictionary<ushort, string> Flash { get; private set; }
        public Dictionary<ushort, string> Compression { get; private set; }
        public Dictionary<ushort, string> Orientation { get; private set; }
        public Dictionary<ushort, string> ExifColorSpace { get; private set; }
        public Dictionary<ushort, string> ExifLightSource { get; private set; }
        public Dictionary<ushort, string> ExifMeteringMode { get; private set; }
        public Dictionary<ushort, string> ExifSensingMethod { get; private set; }
        public Dictionary<ushort, string> CustomRendered { get; private set; }
        public Dictionary<ushort, string> SceneCaptureType { get; private set; }
        public Dictionary<ushort, string> GainControl { get; private set; }
        public Dictionary<ushort, string> SensitivityType { get; private set; }
        public Dictionary<ushort, string> HCUsage { get; private set; }
        public Dictionary<ushort, string> ExposureProgram { get; private set; }
        public Dictionary<ushort, string> Contrast { get; private set; }
        public Dictionary<ushort, string> Saturation { get; private set; }
        public Dictionary<ushort, string> Sharpness { get; private set; }
        public Dictionary<ushort, string> SubjectDistanceRange { get; private set; }
        public Dictionary<ushort, string> ResolutionUnit { get; private set; }
        public Dictionary<ushort, string> FocalPlaneResolutionUnit { get; private set; }
        public Dictionary<ushort, string> Transformation { get; private set; }
        public Dictionary<ushort, string> Uncompressed { get; private set; }
        public Dictionary<ushort, string> ImageDataDiscard { get; private set; }
        public Dictionary<ushort, string> ExposureMode { get; private set; }
        public Dictionary<ushort, string> AlphaDataDiscard { get; private set; }
        public Dictionary<ushort, string> CompositeImage { get; private set; }
        public Dictionary<ushort, string> WhiteBalance { get; private set; }
        public Dictionary<ushort, string> PixelFormat { get; private set; }
        public Dictionary<ushort, string> USPTOOriginalContentType { get; private set; }
        public Dictionary<ushort, string> CR2CFAPattern { get; private set; }
        public Dictionary<ushort, string> CFALayout { get; private set; }
        public Dictionary<ushort, string> ColorimetricReference { get; private set; }
        public Converter<string[], string> DateTimeConverter { get; private set; }
        public Converter<byte[], string> VersionConverter { get; private set; }
        public Converter<Rational[], string> FNumberConverter { get; private set; }
        public Converter<Rational[], string> ToFloatConverter { get; private set; }
        public Converter<Rational[], string> FocalLengthConverter { get; private set; }
        public Converter<byte[], string> BinaryDataConverter { get; private set; }

        public ConversionConstants()
        {
            Flash = new Dictionary<ushort, string>
            {
                [0x0000] = "No flash",
                [0x0001] = "Flash",
                [0x0005] = "Flash, no strobe return",
                [0x0007] = "Flash, strobe return",
                [0x0009] = "Flash, compulsory",
                [0x000D] = "Flash, compulsory, no strobe return",
                [0x000F] = "Flash, compulsory, strobe return",
                [0x0010] = "No flash, compulsory",
                [0x0018] = "No flash, auto",
                [0x0019] = "Flash, auto",
                [0x001D] = "Flash, auto, no strobe return",
                [0x001F] = "Flash, auto, strobe return",
                [0x0020] = "No flash function",
                [0x0041] = "Flash, red-eye",
                [0x0045] = "Flash, red-eye, no strobe return",
                [0x0047] = "Flash, red-eye, strobe return",
                [0x0049] = "Flash, compulsory, red-eye",
                [0x004D] = "Flash, compulsory, red-eye, no strobe return",
                [0x004F] = "Flash, compulsory, red-eye, strobe return",
                [0x0059] = "Flash, auto, red-eye",
                [0x005D] = "Flash, auto, no strobe return, red-eye",
                [0x005F] = "Flash, auto, strobe return, red-eye"
            };
            Compression = new Dictionary<ushort, string>
            {
                [1] = "Uncompressed",
                [2] = "CCITT 1D",
                [3] = "T4 / Group 3 Fax",
                [4] = "T6 / Group 4 Fax",
                [5] = "LZW",
                [6] = "JPEG(old - style)",
                [7] = "JPEG",
                [8] = "Adobe Deflate",
                [9] = "JBIG B & W",
                [10] = "JBIG Color",
                [99] = "JPEG",
                [262] = "Kodak 262",
                [32766] = "Next",
                [32767] = "Sony ARW Compressed",
                [32769] = "Packed RAW",
                [32770] = "Samsung SRW Compressed",
                [32771] = "CCIRLEW",
                [32772] = "Samsung SRW Compressed 2",
                [32773] = "PackBits",
                [32809] = "Thunderscan",
                [32867] = "Kodak KDC Compressed",
                [32895] = "IT8CTPAD",
                [32896] = "IT8LW",
                [32897] = "IT8MP",
                [32898] = "IT8BL",
                [32908] = "PixarFilm",
                [32909] = "PixarLog",
                [32946] = "Deflate",
                [32947] = "DCS",
                [33003] = "Aperio JPEG 2000 YCbCr",
                [33005] = "Aperio JPEG 2000 RGB",
                [34661] = "JBIG",
                [34676] = "SGILog",
                [34677] = "SGILog24",
                [34712] = "JPEG 2000",
                [34713] = "Nikon NEF Compressed",
                [34715] = "JBIG2 TIFF FX",
                [34718] = "Microsoft Document Imaging(MDI) Binary Level Codec",
                [34719] = "Microsoft Document Imaging(MDI) Progressive Transform Codec",
                [34720] = "Microsoft Document Imaging(MDI) Vector",
                [34887] = "ESRI Lerc",
                [34892] = "Lossy JPEG",
                [34925] = "LZMA2",
                [34926] = "Zstd",
                [34927] = "WebP",
                [34933] = "PNG",
                [34934] = "JPEG XR",
                [52546] = "JPEG XL",
                [65000] = "Kodak DCR Compressed",
                [65535] = "Pentax PEF Compressed"
            };
            Orientation = new Dictionary<ushort, string>
            {
                [1] = "0°",
                [2] = "0° Mirrored",
                [3] = "180°",
                [4] = "180° Mirrored",
                [5] = "270° Mirrored",
                [6] = "90°",
                [7] = "90° Mirrored",
                [8] = "270°"
            };
            ResolutionUnit = new Dictionary<ushort, string>
            {
                [1] = "None",
                [2] = "inches",
                [3] = "cm"
            };
            FocalPlaneResolutionUnit = new Dictionary<ushort, string>
            {
                [1] = "None",
                [2] = "inches",
                [3] = "cm",
                [4] = "mm",
                [5] = "um"
            };
            ExifColorSpace = new Dictionary<ushort, string>
            {
                [0x1] = "sRGB",
                [0x2] = "Adobe RGB",
                [0xFFFD] = "Wide Gamut RGB",
                [0xFFFE] = "ICC Profile",
                [0xFFFF] = "Uncalibrated"
            };
            HCUsage = new Dictionary<ushort, string>
            {
                [0] = "CT",
                [1] = "Line Art",
                [2] = "Trap"
            };
            ExposureProgram = new Dictionary<ushort, string>
            {
                [0] = "Not Defined",
                [1] = "Manual",
                [2] = "Program AE",
                [3] = "Aperture - priority AE",
                [4] = "Shutter speed priority AE",
                [5] = "Creative(Slow speed)",
                [6] = "Action(High speed)",
                [7] = "Portrait",
                [8] = "Landscape",
                [9] = "Bulb"
            };
            SensitivityType = new Dictionary<ushort, string>
            {
                [0] = "Unknown",
                [1] = "Standard Output Sensitivity",
                [2] = "Recommended Exposure Index",
                [3] = "ISO Speed",
                [4] = "Standard Output Sensitivity and Recommended Exposure Index",
                [5] = "Standard Output Sensitivity and ISO Speed",
                [6] = "Recommended Exposure Index and ISO Speed",
                [7] = "Standard Output Sensitivity, Recommended Exposure Index and ISO Speed"
            };
            WhiteBalance = new Dictionary<ushort, string>
            {
                [0] = "Auto",
                [1] = "Manual"
            };
            ExifLightSource = new Dictionary<ushort, string>
            {
                [0] = "Unknown",
                [1] = "Daylight",
                [2] = "Fluorescent",
                [3] = "Tungsten (Incandescent)",
                [4] = "Flash",
                [9] = "Fine Weather",
                [10] = "Cloudy",
                [11] = "Shade",
                [12] = "Daylight Fluorescent",
                [13] = "Day White Fluorescent",
                [14] = "Cool White Fluorescent",
                [15] = "White Fluorescent",
                [16] = "Warm White Fluorescent",
                [17] = "Standard Light A",
                [18] = "Standard Light B",
                [19] = "Standard Light C",
                [20] = "D55",
                [21] = "D65",
                [22] = "D75",
                [23] = "D50",
                [24] = "ISO Studio Tungsten",
                [255] = "Other"
            };
            ExifMeteringMode = new Dictionary<ushort, string>
            {
                [0] = "Unknown",
                [1] = "Average",
                [2] = "Center-weighted average",
                [3] = "Spot",
                [4] = "Multi-spot",
                [5] = "Multi-segment",
                [6] = "Partial",
                [255] = "Other"
            };
            ExifSensingMethod = new Dictionary<ushort, string>
            {
                [1] = "Not defined",
                [2] = "One-chip color area",
                [3] = "Two-chip color area",
                [4] = "Three-chip color area",
                [5] = "Color sequential area",
                [7] = "Trilinear",
                [8] = "Color sequential linear"
            };
            CustomRendered = new Dictionary<ushort, string>
            {
                [0] = "Normal",
                [1] = "Custom",
                [2] = "HDR(no original saved)",
                [3] = "HDR(original saved)",
                [4] = "Original(for HDR)",
                [6] = "Panorama",
                [7] = "Portrait HDR",
                [8] = "Portrait"
            };
            SceneCaptureType = new Dictionary<ushort, string>
            {
                [0] = "Standard",
                [1] = "Landscape",
                [2] = "Portrait",
                [3] = "Night",
                [4] = "Other"
            };
            GainControl = new Dictionary<ushort, string>
            {
                [0] = "None",
                [1] = "Low gain up",
                [2] = "High gain up",
                [3] = "Low gain down",
                [4] = "High gain down"
            };
            Contrast = new Dictionary<ushort, string>
            {
                [0] = "Normal",
                [1] = "Low",
                [2] = "High"
            };
            Saturation = new Dictionary<ushort, string>
            {
                [0] = "Normal",
                [1] = "Low",
                [2] = "High"
            };
            Sharpness = new Dictionary<ushort, string>
            {
                [0] = "Normal",
                [1] = "Soft",
                [2] = "Hard"
            };
            SubjectDistanceRange = new Dictionary<ushort, string>
            {
                [0] = "Unknown",
                [1] = "Macro",
                [2] = "Close",
                [3] = "Distant"
            };
            CompositeImage = new Dictionary<ushort, string>
            {
                [0] = "Unknown",
                [1] = "Not a Composite Image",
                [2] = "General Composite Image",
                [3] = "Composite Image Captured While Shooting"
            };
            PixelFormat = new Dictionary<ushort, string>
            {
                [0x5] = "Black & White",
                [0x8] = "8-bit Gray",
                [0x9] = "16-bit BGR555",
                [0xa] = "16-bit BGR565",
                [0xb] = "16-bit Gray",
                [0xc] = "24-bit BGR",
                [0xd] = "24-bit RGB",
                [0xe] = "32-bit BGR",
                [0xf] = "32-bit BGRA",
                [0x10] = "32-bit PBGRA",
                [0x11] = "32-bit Gray Float",
                [0x12] = "48-bit RGB Fixed Point",
                [0x13] = "32-bit BGR101010",
                [0x15] = "48-bit RGB",
                [0x16] = "64-bit RGBA",
                [0x17] = "64-bit PRGBA",
                [0x18] = "96-bit RGB Fixed Point",
                [0x19] = "128-bit RGBA Float",
                [0x1a] = "128-bit PRGBA Float",
                [0x1b] = "128-bit RGB Float",
                [0x1c] = "32-bit CMYK",
                [0x1d] = "64-bit RGBA Fixed Point",
                [0x1e] = "128-bit RGBA Fixed Point",
                [0x1f] = "64-bit CMYK",
                [0x20] = "24-bit 3 Channels",
                [0x21] = "32-bit 4 Channels",
                [0x22] = "40-bit 5 Channels",
                [0x23] = "48-bit 6 Channels",
                [0x24] = "56-bit 7 Channels",
                [0x25] = "64-bit 8 Channels",
                [0x26] = "48-bit 3 Channels",
                [0x27] = "64-bit 4 Channels",
                [0x28] = "80-bit 5 Channels",
                [0x29] = "96-bit 6 Channels",
                [0x2a] = "112-bit 7 Channels",
                [0x2b] = "128-bit 8 Channels",
                [0x2c] = "40-bit CMYK Alpha",
                [0x2d] = "80-bit CMYK Alpha",
                [0x2e] = "32-bit 3 Channels Alpha",
                [0x2f] = "40-bit 4 Channels Alpha",
                [0x30] = "48-bit 5 Channels Alpha",
                [0x31] = "56-bit 6 Channels Alpha",
                [0x32] = "64-bit 7 Channels Alpha",
                [0x33] = "72-bit 8 Channels Alpha",
                [0x34] = "64-bit 3 Channels Alpha",
                [0x35] = "80-bit 4 Channels Alpha",
                [0x36] = "96-bit 5 Channels Alpha",
                [0x37] = "112-bit 6 Channels Alpha",
                [0x38] = "128-bit 7 Channels Alpha",
                [0x39] = "144-bit 8 Channels Alpha",
                [0x3a] = "64-bit RGBA Half",
                [0x3b] = "48-bit RGB Half",
                [0x3d] = "32-bit RGBE",
                [0x3e] = "16-bit Gray Half",
                [0x3f] = "32-bit Gray Fixed Point"
            };
            Transformation = new Dictionary<ushort, string>
            {
                [0] = "Horizontal(normal)",
                [1] = "Mirror vertical",
                [2] = "Mirror horizontal",
                [3] = "Rotate 180",
                [4] = "Rotate 90 CW",
                [5] = "Mirror horizontal and rotate 90 CW",
                [6] = "Mirror horizontal and rotate 270 CW",
                [7] = "Rotate 270 CW"
            };
            Uncompressed = new Dictionary<ushort, string>
            {
                [0] = "No",
                [1] = "Yes"
            };
            ImageDataDiscard = new Dictionary<ushort, string>
            {
                [0] = "Full Resolution",
                [1] = "Flexbits Discarded",
                [2] = "HighPass Frequency Data Discarded",
                [3] = "Highpass and LowPass Frequency Data Discarded"
            };
            AlphaDataDiscard = new Dictionary<ushort, string>
            {
                [0] = "Full Resolution",
                [1] = "Flexbits Discarded",
                [2] = "HighPass Frequency Data Discarded",
                [3] = "Highpass and LowPass Frequency Data Discarded"
            };
            USPTOOriginalContentType = new Dictionary<ushort, string>
            {
                [0] = "Text or Drawing",
                [1] = "Grayscale",
                [2] = "Color"
            };
            CR2CFAPattern = new Dictionary<ushort, string>
            {
                [1] = "0 1 1 2",
                [4] = "1 0 2 1",
                [3] = "1 2 0 1",
                [2] = "2 1 1 0"
            };
            CFALayout = new Dictionary<ushort, string>
            {
                [1] = "Rectangular",
                [2] = "Even columns offset down 1 / 2 row",
                [3] = "Even columns offset up 1 / 2 row",
                [4] = "Even rows offset right 1 / 2 column",
                [5] = "Even rows offset left 1 / 2 column",
                [6] = "Even rows offset up by 1 / 2 row, even columns offset left by 1 / 2 column",
                [7] = "Even rows offset up by 1 / 2 row, even columns offset right by 1 / 2 column",
                [8] = "Even rows offset down by 1 / 2 row, even columns offset left by 1 / 2 column",
                [9] = "Even rows offset down by 1 / 2 row, even columns offset right by 1 / 2 column"
            };
            ColorimetricReference = new Dictionary<ushort, string>
            {
                [0] = "Scene - referred",
                [1] = "Output - referred(ICC Profile Dynamic Range)",
                [2] = "Output - referred(High Dyanmic Range)"
            };
            ExposureMode = new Dictionary<ushort, string>
            {
                [0] = "Auto",
                [1] = "Manual",
                [2] = "Auto bracket"
            };
            DateTimeConverter = str =>
            {
                if (str[0] == string.Empty) return string.Empty;
                return string.Join(",", DateTime.ParseExact(str[0], "yyyy:MM:dd HH:mm:ss", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy HH:mm:ss"));
            };
            FNumberConverter = rat => string.Join(",", rat.Select(r => "f/" + r.ValueOf().ToString("0.##")));
            ToFloatConverter = rat => string.Join(",", rat.Select(r => r.ValueOf().ToString("0.##")));
            VersionConverter = obj => string.Join(".", obj.Select(v => (char)v));
            FocalLengthConverter = rat => string.Join(",", rat.Select(r => r.ValueOf().ToString("0.##") + " mm"));
            BinaryDataConverter = b => $"<Dữ liệu nhị phân, {b.Length} bytes>";
        }
    }
}
