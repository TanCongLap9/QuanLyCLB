using QuanLyCLB.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class SqlUtils
    {
        public const string NguoiDung_Them = "NguoiDung_Them";
        public const string NguoiDung_Xoa = "NguoiDung_Xoa";
        public const string NguoiDung_Sua = "NguoiDung_Sua";
        public const string NguoiDung_DangNhap = "NguoiDung_DangNhap";
        public const string NguoiDung_ThongTin = "NguoiDung_ThongTin";
        public const string NguoiDung_TimKiem = "NguoiDung_TimKiem";
        public const string CauLacBo_TimKiem = "CauLacBo_TimKiem";
        public const string CauLacBo_DanhSach = "CauLacBo_DanhSach";
        public const string CauLacBo_Them = "CauLacBo_Them";
        public const string CauLacBo_ThongTin = "CauLacBo_ThongTin";
        public const string CauLacBo_Xoa = "CauLacBo_Xoa";
        public const string CauLacBo_Sua = "CauLacBo_Sua";
        public const string DuongLinkCauLacBo_DanhSach = "DuongLinkCauLacBo_DanhSach";
        public const string DuongLinkCauLacBo_Xoa = "DuongLinkCauLacBo_Xoa";
        public const string DuongLinkCauLacBo_Them = "DuongLinkCauLacBo_Them";
        public const string DuongLinkCauLacBo_Sua = "DuongLinkCauLacBo_Sua";
        public const string ThanhVien_DanhSach = "ThanhVien_DanhSach";
        public const string ThanhVien_ThongTin = "ThanhVien_ThongTin";
        public const string ThanhVien_Sua = "ThanhVien_Sua";
        public const string ThanhVien_Them = "ThanhVien_Them";
        public const string ThanhVien_Xoa = "ThanhVien_Xoa";
        public const string BaiViet_DanhSach = "BaiViet_DanhSach";
        public const string BaiViet_Them = "BaiViet_Them";
        public const string BaiViet_ThongTin = "BaiViet_ThongTin";
        public const string BaiViet_Sua = "BaiViet_Sua";
        public const string LoaiLich_DanhSach = "LoaiLich_DanhSach";
        public const string LoaiLich_Sua = "LoaiLich_Sua";
        public const string LoaiLich_Them = "LoaiLich_Them";
        public const string LoaiLich_Xoa = "LoaiLich_Xoa";
        public const string Lich_ThongTin = "Lich_ThongTin";
        public const string Lich_DanhSach = "Lich_DanhSach";
        public const string Lich_Sua = "Lich_Sua";
        public const string Lich_Them = "Lich_Them";
        public const string Lich_Xoa = "Lich_Xoa";
        public const string TapTin_Xoa = "TapTin_Xoa";
        public const string TapTin_ThongTin = "TapTin_ThongTin";
        public const string TapTin_DiChuyen = "TapTin_DiChuyen";
        public const string TapTin_SaoChep = "TapTin_SaoChep";
        public const string TapTin_DanhSach = "TapTin_DanhSach";
        public const string TapTin_Them = "TapTin_Them";
        public const string TapTin_DoiTen = "TapTin_DoiTen";
        public const string ThuMuc_Xoa = "ThuMuc_Xoa";
        public const string ThuMuc_DanhSach = "ThuMuc_DanhSach";
        public const string ThuMuc_ThongTin = "ThuMuc_ThongTin";
        public const string ThuMuc_Sua = "ThuMuc_Sua";
        public const string ThuMuc_Them = "ThuMuc_Them";
        public const string ThongBao_SqlDependency = "ThongBao_SqlDependency";
        public const string ThongBao_DanhSach = "ThongBao_DanhSach";
        public const string ThongBao_ThongTin = "ThongBao_ThongTin";
        public const string ThongBao_Them = "ThongBao_Them";

        public static SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString);

        public static async Task<SqlConnection> CreateConnection()
        {
            SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString);
            await conn.OpenAsync();
            return conn;
        }
        
        public static string ConnectionString
        {
            get { return Settings.Default.ConnectionString; }
        }

        public static async Task<int> ExecuteAsync(string command, Dictionary<string, object> parameters = null, CommandType type = CommandType.Text, CancellationToken? tok = null, SqlTransaction trans = null)
        {
            // await Task.Delay(500);

            if (trans == null)
                using (SqlConnection connection = new SqlConnection(Settings.Default.ConnectionString))
                {
                    await connection.OpenAsync();
                    using (SqlCommand comm = new SqlCommand(command, connection))
                    {
                        comm.CommandType = type;
                        if (parameters != null)
                            foreach (KeyValuePair<string, object> param in parameters)
                                comm.Parameters.AddWithValue(param.Key, param.Value);
                        try
                        {
                            int rowsAffected = await comm.ExecuteNonQueryAsync(tok ?? CancellationToken.None);
                            return rowsAffected;
                        }
                        catch (InvalidOperationException exc)
                        {
                            if (exc.Message == Resources.SqlOperationCancelled)
                                throw new OperationCanceledException();
                            throw;
                        }
                    }
                }
            else
                using (SqlCommand comm = new SqlCommand(command, trans.Connection, trans))
                {
                    comm.CommandType = type;
                    if (parameters != null)
                        foreach (KeyValuePair<string, object> param in parameters)
                            comm.Parameters.AddWithValue(param.Key, param.Value);
                    int rowsAffected = await comm.ExecuteNonQueryAsync(tok ?? CancellationToken.None);
                    return rowsAffected;
                }
        }

        public static async Task<DataTable> QueryTableAsync(string command, Dictionary<string, object> parameters = null, CommandType type = CommandType.Text, SqlTransaction trans = null)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    comm.CommandType = type;
                    if (parameters != null)
                        foreach (KeyValuePair<string, object> param in parameters)
                            comm.Parameters.AddWithValue(param.Key, param.Value);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(comm))
                    {
                        DataTable table = new DataTable();
                        await Task.Run(() => adapter.Fill(table));
                        conn.Close();
                        return table;
                    }
                }
            }
        }

        public static DataReaderNew QueryReaderNew(string command, Dictionary<string, object> parameters = null, CommandType type = CommandType.Text, CommandBehavior commandBehavior = CommandBehavior.Default, CancellationToken? cancellationToken = null, SqlTransaction trans = null)
        {
            return new DataReaderNew(command, parameters, type, commandBehavior, cancellationToken ?? CancellationToken.None, trans);
        }

        public static async Task<T> QueryScalarAsync<T>(string command, Dictionary<string, object> parameters = null, CommandType type = CommandType.Text, CancellationToken? cancellationToken = null, SqlTransaction trans = null)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                await conn.OpenAsync();
                using (SqlCommand comm = new SqlCommand(command, conn))
                {
                    comm.CommandType = type;
                    if (parameters != null)
                        foreach (KeyValuePair<string, object> param in parameters)
                            comm.Parameters.AddWithValue(param.Key, param.Value);
                    return (T)await comm.ExecuteScalarAsync(cancellationToken ?? CancellationToken.None);
                }
            }
        }

        public static async Task Do(Action<SqlConnection> action)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                await conn.OpenAsync();
                action.Invoke(conn);
                conn.Close();
            }
        }

        public static async Task Do(Func<SqlConnection, Task> action)
        {
            using (SqlConnection conn = new SqlConnection(Settings.Default.ConnectionString))
            {
                await conn.OpenAsync();
                await action.Invoke(conn);
                conn.Close();
            }
        }
    }

    public class DataReaderNew : IDisposable
    {
        private readonly string Command;
        private readonly Dictionary<string, object> Parameters;
        private readonly CommandType Type;
        private readonly CommandBehavior CommandBehavior;
        private readonly CancellationToken Token;
        private SqlConnection Conn;
        private SqlCommand Comm;
        private SqlDataReader Reader;

        public DataReaderNew(string command, Dictionary<string, object> parameters, CommandType type, CommandBehavior commandBehavior, CancellationToken cancellationToken, SqlTransaction trans)
        {
            Command = command;
            Parameters = parameters;
            Type = type;
            CommandBehavior = commandBehavior;
            Token = cancellationToken;
            Trans = trans;
        }

        public SqlTransaction Trans { get; private set; }

        private async Task InitializeAsync()
        {
            Token.ThrowIfCancellationRequested();
            Conn = new SqlConnection(Settings.Default.ConnectionString);
            await Conn.OpenAsync();
            Comm = new SqlCommand(Command, Conn);
            Comm.CommandType = Type;
            if (Parameters != null)
                foreach (KeyValuePair<string, object> param in Parameters)
                    Comm.Parameters.AddWithValue(param.Key, param.Value);
            Reader = await Comm.ExecuteReaderAsync(CommandBehavior, Token);
        }

        /// <summary>
        /// Gets the <see cref="SqlDataReader"/>.
        /// 
        /// Be sure to clean it up after processing
        /// </summary>
        /// <exception cref="OperationCanceledException" />
        public async Task<SqlDataReader> GetReader()
        {
            await InitializeAsync();
            Token.ThrowIfCancellationRequested();
            return Reader;
        }

        /// <summary>
        /// Do synchronous action when a reader is initialized
        /// </summary>
        /// <exception cref="OperationCanceledException" />
        /// <exception cref="Exception" />
        public async Task Then(Action<SqlDataReader> action, bool dispose = true)
        {
            try
            {
                await InitializeAsync();
                Token.ThrowIfCancellationRequested();
                action.Invoke(Reader);
            }
            finally
            {
                if (dispose) Dispose();
            }
        }

        /// <summary>
        /// Do asynchronous action when a reader is initialized
        /// </summary>
        /// <exception cref="OperationCanceledException" />
        /// <exception cref="Exception" />
        public async Task Then(Func<SqlDataReader, Task> action, bool dispose = true)
        {
            try
            {
                await InitializeAsync();
                Token.ThrowIfCancellationRequested();
                await action.Invoke(Reader);
            }
            finally
            {
                if (dispose) Dispose();
            }
        }

        /// <summary>
        /// Iterates reader asynchronously and runs action synchronously when a reader is initialized
        /// </summary>
        /// <exception cref="OperationCanceledException" />
        /// <exception cref="Exception" />
        public async Task ForEach(Action<SqlDataReader> action)
        {
            try
            {
                await InitializeAsync();
                while (await Reader.ReadAsync(Token))
                {
                    Token.ThrowIfCancellationRequested();
                    action.Invoke(Reader);
                }
            }
            catch (SqlException exc)
            {
                if (exc.Class == 11 && exc.Number == 0 && exc.State == 0 && exc.Message.Contains(Resources.SqlOperationCancelled))
                    throw new OperationCanceledException();
                throw;
            }
            finally
            {
                Dispose();
            }
        }

        /// <summary>
        /// Iterates reader and runs action asynchronously when a reader is initialized
        /// </summary>
        /// <exception cref="OperationCanceledException" />
        /// <exception cref="Exception" />
        public async Task ForEach(Func<SqlDataReader, Task> action)
        {
            try
            {
                await InitializeAsync();
                while (await Reader.ReadAsync(Token))
                {
                    Token.ThrowIfCancellationRequested();
                    await action.Invoke(Reader);
                }
            }
            catch (SqlException exc)
            {
                if (exc.Class == 11 && exc.Number == 0 && exc.State == 0 && exc.Message.Contains(Resources.SqlOperationCancelled))
                    throw new OperationCanceledException();
                throw;
            }
            catch (InvalidOperationException exc)
            {
                if (exc.Message == Resources.SqlOperationCancelled)
                    throw new OperationCanceledException();
                throw;
            }
            finally
            {
                Dispose();
            }
        }

        public void Dispose()
        {
            if (Reader != null && !Reader.IsClosed)
                Reader.Close();
            Comm?.Dispose();
            Conn?.Dispose();
        }
    }
}
