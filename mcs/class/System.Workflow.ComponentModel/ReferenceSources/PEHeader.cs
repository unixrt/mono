using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Microsoft.Workflow.Compiler
{
    internal static class PEHeader
    {
        private const ushort IMAGE_DOS_SIGNATURE = 23117;

        private const uint IMAGE_NT_SIGNATURE = 17744;

        private const ushort IMAGE_FILE_MACHINE_IA64 = 512;

        private const ushort IMAGE_FILE_MACHINE_AMD64 = 34404;

        public static bool Is64BitRequiredExecutable(string path)
        {
            bool flag;
            using (Stream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                PEHeader.IMAGE_DOS_HEADER mAGEDOSHEADER = PEHeader.ReadHelper.ReadFromStream<PEHeader.IMAGE_DOS_HEADER>(fileStream);
                if (mAGEDOSHEADER.e_magic != 23117)
                {
                    object[] objArray = new object[] { path };
                    throw new InvalidDataException(WrapperSR.GetString("InvalidAssemblyHeader", objArray));
                }
                fileStream.Position = (long)mAGEDOSHEADER.e_lfanew;
                PEHeader.IMAGE_NT_HEADERS mAGENTHEADER = PEHeader.ReadHelper.ReadFromStream<PEHeader.IMAGE_NT_HEADERS>(fileStream);
                if (mAGENTHEADER.Signature != 17744)
                {
                    object[] objArray1 = new object[] { path };
                    throw new InvalidDataException(WrapperSR.GetString("InvalidAssemblyHeader", objArray1));
                }
                ushort machine = mAGENTHEADER.FileHeader.Machine;
                flag = (machine == 512 || machine == 34404 ? true : false);
            }
            return flag;
        }

        private struct IMAGE_DATA_DIRECTORY
        {
            public uint VirtualAddress;

            public uint Size;
        }

        private class IMAGE_DOS_HEADER
        {
            public ushort e_magic;

            public ushort e_cblp;

            public ushort e_cp;

            public ushort e_crlc;

            public ushort e_cparhdr;

            public ushort e_minalloc;

            public ushort e_maxalloc;

            public ushort e_ss;

            public ushort e_sp;

            public ushort e_csum;

            public ushort e_ip;

            public ushort e_cs;

            public ushort e_lfarlc;

            public ushort e_ovno;

            public ushort[] e_res1;

            public ushort e_oemid;

            public ushort e_oeminfo;

            public ushort[] e_res2;

            public int e_lfanew;

            public IMAGE_DOS_HEADER()
            {
            }
        }

        private struct IMAGE_FILE_HEADER
        {
            public ushort Machine;

            public ushort NumberOfSections;

            public uint TimeDateStamp;

            public uint PointerToSymbolTable;

            public uint NumberOfSymbols;

            public ushort SizeOfOptionalHeader;

            public ushort Characteristics;
        }

        private class IMAGE_NT_HEADERS
        {
            public uint Signature;

            public PEHeader.IMAGE_FILE_HEADER FileHeader;

            public PEHeader.IMAGE_OPTIONAL_HEADER32 OptionalHeader;

            public IMAGE_NT_HEADERS()
            {
            }
        }

        private struct IMAGE_OPTIONAL_HEADER32
        {
            public ushort Magic;

            public byte MajorLinkerVersion;

            public byte MinorLinkerVersion;

            public uint SizeOfCode;

            public uint SizeOfInitializedData;

            public uint SizeOfUninitializedData;

            public uint AddressOfEntryPoint;

            public uint BaseOfCode;

            public uint BaseOfData;

            public uint ImageBase;

            public uint SectionAlignment;

            public uint FileAlignment;

            public ushort MajorOperatingSystemVersion;

            public ushort MinorOperatingSystemVersion;

            public ushort MajorImageVersion;

            public ushort MinorImageVersion;

            public ushort MajorSubsystemVersion;

            public ushort MinorSubsystemVersion;

            public uint Win32VersionValue;

            public uint SizeOfImage;

            public uint SizeOfHeaders;

            public uint CheckSum;

            public ushort Subsystem;

            public ushort DllCharacteristics;

            public uint SizeOfStackReserve;

            public uint SizeOfStackCommit;

            public uint SizeOfHeapReserve;

            public uint SizeOfHeapCommit;

            public uint LoaderFlags;

            public uint NumberOfRvaAndSizes;

            public PEHeader.IMAGE_DATA_DIRECTORY[] DataDirectory;
        }

        private static class ReadHelper
        {
            private static byte[] ReadBufferFromStream(Stream source, int bufferSize)
            {
                byte[] numArray = new byte[bufferSize];
                source.Read(numArray, 0, bufferSize);
                return numArray;
            }

            public static T ReadFromStream<T>(Stream source)
            where T : class, new()
            {
                unsafe
                {
                    byte* numPointer;
                    byte[] numArray = PEHeader.ReadHelper.ReadBufferFromStream(source, Marshal.SizeOf(typeof(T)));
                    byte[] numArray1 = numArray;
                    byte[] numArray2 = numArray1;
                    if (numArray1 == null || (int)numArray2.Length == 0)
                    {
                        numPointer = null;
                    }
                    else
                    {
			fixed(byte* b1 = &numArray2[0]) {
				numPointer = b1;
			}
                    }
                    return (T)Marshal.PtrToStructure((IntPtr)numPointer, typeof(T));
                }
            }
        }
    }
}
