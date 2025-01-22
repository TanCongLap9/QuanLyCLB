using QuanLyCLB.TaskWindow;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using System.Security.AccessControl;
using System.Threading;
using System.Runtime.Remoting;

namespace QuanLyCLB
{
    public class FileStream2 : FileStream
    {
        public event EventHandler<long> LengthChanged; // Tải về
        public event EventHandler<long> PositionChanged; // Tải lên

        public FileStream2(string path, FileMode mode) : base(path, mode)
        {

        }

        [Obsolete]
        public FileStream2(IntPtr handle, FileAccess access) : base(handle, access)
        {

        }

        public FileStream2(SafeFileHandle handle, FileAccess access) : base(handle, access)
        {

        }

        public FileStream2(string path, FileMode mode, FileAccess access) : base(path, mode, access)
        {

        }

        [Obsolete]
        public FileStream2(IntPtr handle, FileAccess access, bool ownsHandle) : base(handle, access, ownsHandle)
        {

        }

        public FileStream2(SafeFileHandle handle, FileAccess access, int bufferSize) : base(handle, access, bufferSize)
        {

        }

        public FileStream2(string path, FileMode mode, FileAccess access, FileShare share) : base(path, mode, access, share)
        {

        }

        [Obsolete]
        public FileStream2(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) : base(handle, access, ownsHandle, bufferSize)
        {

        }

        public FileStream2(SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) : base(handle, access, bufferSize, isAsync)
        {

        }

        public FileStream2(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) : base(path, mode, access, share, bufferSize)
        {

        }

        [Obsolete]
        public FileStream2(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync) : base(handle, access, ownsHandle, bufferSize, isAsync)
        {

        }

        public FileStream2(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) : base(path, mode, access, share, bufferSize, options)
        {

        }

        public FileStream2(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) : base(path, mode, access, share, bufferSize, useAsync)
        {

        }

        public FileStream2(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options) : base(path, mode, rights, share, bufferSize, options)
        {

        }

        public FileStream2(string path, FileMode mode, FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, FileSecurity fileSecurity) : base(path, mode, rights, share, bufferSize, options, fileSecurity)
        {

        }

        public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            IAsyncResult result = base.BeginRead(array, offset, numBytes, userCallback, stateObject);
            PositionChanged?.Invoke(this, this.Position);
            return result;
        }

        public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject)
        {
            IAsyncResult result = base.BeginWrite(array, offset, numBytes, userCallback, stateObject);
            LengthChanged?.Invoke(this, this.Length);
            return result;
        }

        public override int Read(byte[] array, int offset, int count)
        {
            int result = base.Read(array, offset, count);
            PositionChanged?.Invoke(this, this.Position);
            return result;
        }

        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            Task<int> result = base.ReadAsync(buffer, offset, count, cancellationToken);
            PositionChanged?.Invoke(this, this.Position);
            return result;
        }

        public override int ReadByte()
        {
            int result = base.ReadByte();
            PositionChanged?.Invoke(this, this.Position);
            return result;
        }

        public override void Write(byte[] array, int offset, int count)
        {
            base.Write(array, offset, count);
            LengthChanged?.Invoke(this, this.Length);
        }

        public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
        {
            Task result = base.WriteAsync(buffer, offset, count, cancellationToken);
            LengthChanged?.Invoke(this, this.Length);
            return result;
        }

        public override void WriteByte(byte value)
        {
            base.WriteByte(value);
            LengthChanged?.Invoke(this, this.Length);
        }
    }
}
