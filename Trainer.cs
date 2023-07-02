using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.InteropServices;


public class Trainer
{
    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
    [DllImport("kernel32")]
    private static extern int OpenProcess(int AccessType, int InheritHandle, int ProcessId);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern byte WriteProcessMemoryByte(int Handle, int Address, ref byte Value, int Size, ref int BytesWritten);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern int WriteProcessMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesWritten);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern float WriteProcessMemoryFloat(int Handle, int Address, ref float Value, int Size, ref int BytesWritten);
    [DllImport("kernel32", EntryPoint = "WriteProcessMemory")]
    private static extern double WriteProcessMemoryDouble(int Handle, int Address, ref double Value, int Size, ref int BytesWritten);


    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern byte ReadProcessMemoryByte(int Handle, int Address, ref byte Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern int ReadProcessMemoryInteger(int Handle, int Address, ref int Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern float ReadProcessMemoryFloat(int Handle, int Address, ref float Value, int Size, ref int BytesRead);
    [DllImport("kernel32", EntryPoint = "ReadProcessMemory")]
    private static extern double ReadProcessMemoryDouble(int Handle, int Address, ref double Value, int Size, ref int BytesRead);
    [DllImport("kernel32")]
    private static extern int CloseHandle(int Handle);

    [DllImport("user32")]
    private static extern int FindWindow(string sClassName, string sAppName);
    [DllImport("user32")]
    private static extern int GetWindowThreadProcessId(int HWND, out int processId);


    public static string CheckGame(string WindowTitle)
    {
        string result = "";
        checked
        {
            try
            {
                int Proc;
                int HWND = FindWindow(null, WindowTitle);
                GetWindowThreadProcessId(HWND, out Proc);
                int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc);
                if (Handle != 0)
                {
                    result = "Game is running...";
                }
                else
                {
                    result = "Game is not running...";
                }
                CloseHandle(Handle);
            }
            catch
            { }
        }
        return result;
    }
    public static byte ReadByte(string EXENAME, int Address)
    {
        byte Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryByte(Handle, Address, ref Value, 2, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static int ReadInteger(string EXENAME, int Address)
    {
        int Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryInteger(Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadFloat(string EXENAME, int Address)
    {
        float Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryFloat((int)Handle, Address, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static double ReadDouble(string EXENAME, int Address)
    {
        double Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        ReadProcessMemoryDouble((int)Handle, Address, ref Value, 8, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }

    public static byte ReadPointerByte(string EXENAME, int Pointer, int[] Offset)
    {
        byte Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryByte((int)Handle, Pointer, ref Value, 2, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static int ReadPointerInteger(string EXENAME, int Pointer, int[] Offset)
    {
        int Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryInteger((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static int ReadPointerInteger(Process[] Proc, int Pointer, int[] Offset) {
        int Value = 0;
        checked {
            try {
                if (Proc.Length != 0) {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0) {
                        foreach (int i in Offset) {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryInteger((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            } catch { }
        }
        return Value;
    }
    public static float ReadPointerFloat(string EXENAME, int Pointer, int[] Offset)
    {
        float Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryFloat((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static float ReadPointerFloat(Process[] Proc, int Pointer, int[] Offset) {
        float Value = 0;
        checked {
            try {
                if (Proc.Length != 0) {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0) {
                        foreach (int i in Offset) {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryFloat((int)Handle, Pointer, ref Value, 4, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            } catch { }
        }
        return Value;
    }
    public static double ReadPointerDouble(string EXENAME, int Pointer, int[] Offset)
    {
        double Value = 0;
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryDouble((int)Handle, Pointer, ref Value, 8, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            }
            catch
            { }
        }
        return Value;
    }
    public static double ReadPointerDouble(Process[] Proc, int Pointer, int[] Offset) {
        double Value = 0;
        checked {
            try {
                if (Proc.Length != 0) {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0) {
                        foreach (int i in Offset) {
                            ReadProcessMemoryInteger((int)Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        ReadProcessMemoryDouble((int)Handle, Pointer, ref Value, 8, ref Bytes);
                        CloseHandle(Handle);
                    }
                }
            } catch { }
        }
        return Value;
    }

    public static void WriteByte(string EXENAME, int Address, byte Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryByte(Handle, Address, ref Value, 2, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WriteInteger(string EXENAME, int Address, int Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryInteger(Handle, Address, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WriteFloat(string EXENAME, int Address, float Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryFloat(Handle, Address, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }

            }
            catch
            { }
        }
    }
    public static void WriteDouble(string EXENAME, int Address, double Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Bytes = 0;
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        WriteProcessMemoryDouble(Handle, Address, ref Value, 8, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }

    public static void WritePointerByte(string EXENAME, int Pointer, int[] Offset, byte Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryByte(Handle, Pointer, ref Value, 2, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WritePointerInteger(string EXENAME, int Pointer, int[] Offset, int Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryInteger(Handle, Pointer, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WritePointerFloat(string EXENAME, int Pointer, int[] Offset, float Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryFloat(Handle, Pointer, ref Value, 4, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
    public static void WritePointerDouble(string EXENAME, int Pointer, int[] Offset, double Value)
    {
        checked
        {
            try
            {
                Process[] Proc = Process.GetProcessesByName(EXENAME);
                if (Proc.Length != 0)
                {
                    int Handle = OpenProcess(PROCESS_ALL_ACCESS, 0, Proc[0].Id);
                    if (Handle != 0)
                    {
                        int Bytes = 0;
                        foreach (int i in Offset)
                        {
                            ReadProcessMemoryInteger(Handle, Pointer, ref Pointer, 4, ref Bytes);
                            Pointer += i;
                        }
                        WriteProcessMemoryDouble(Handle, Pointer, ref Value, 8, ref Bytes);
                    }
                    CloseHandle(Handle);
                }
            }
            catch
            { }
        }
    }
}