using System;
using System.Runtime.InteropServices;

// Token: 0x0200000E RID: 14
internal class Class7
{
	// Token: 0x06000065 RID: 101
	[DllImport("user32.dll", SetLastError = true)]
	public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

	// Token: 0x06000066 RID: 102
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool OpenClipboard(IntPtr hWndNewOwner);

	// Token: 0x06000067 RID: 103
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseClipboard();

	// Token: 0x06000068 RID: 104
	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetClipboardData(uint uFormat, IntPtr hMem);

	// Token: 0x06000069 RID: 105
	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

	// Token: 0x0600006A RID: 106
	[DllImport("KERNEL32.DLL", SetLastError = true)]
	public static extern IntPtr GlobalLock(IntPtr hMem);

	// Token: 0x0600006B RID: 107
	[DllImport("KERNEL32.DLL", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GlobalUnlock(IntPtr hMem);

	// Token: 0x0600006C RID: 108
	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EmptyClipboard();

	// Token: 0x0600006E RID: 110 RVA: 0x00002492 File Offset: 0x00000692
	internal static bool Mela74Sln7neBRoIS7W()
	{
		return Class7.mOpd4kS7ZbNUh9E2DXr == null;
	}

	// Token: 0x04000022 RID: 34
	private static Class7 mOpd4kS7ZbNUh9E2DXr;
}
