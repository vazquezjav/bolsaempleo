/*using BolsaEmpleo.DAL.DBContext;
using BolsaEmpleo.EXCEPTIONS;
using Dapper;
using Microsoft.Extensions.Configuration;
//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.DAL.DBContext
{
    public class MySqlDbContext : IDbContext
    {
        public readonly string _connectionString;

        public MySqlDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("MysqlDBConnection");
        }

        public void excecuteProcedure(string query, object parameters)
        {
            throw new NotImplementedException();
        }

        *//*private MySqlConnection getConnection() {
            return new MySqlConnection(_connectionString);
        }*//*

        public void excecuteQuery(string query)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlMapper.Query(conn, query, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new MysglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void excecuteQuery(string query, object parameters)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlMapper.Query(conn, query, param: parameters, commandType: CommandType.Text);
            }
            catch (Exception ex)
            {
                throw new DbPsglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public Task excecuteQueryAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task excecuteQueryAsync(string query, object parameters)
        {
            throw new NotImplementedException();
        }

        public List<T> getList<T>(string query)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return SqlMapper.Query<T>(conn, query, commandType: CommandType.Text).ToList();
            }
            catch (Exception ex)
            {
                throw new DbPsglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public List<T> getList<T>(string query, object parameters)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return SqlMapper.Query<T>(conn, query, param: parameters, commandType: CommandType.Text, commandTimeout: 50).ToList();
            }
            catch (Exception ex)
            {
                throw new DbPsglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public T getObject<T>(string query)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                var l = SqlMapper.Query<T>(conn, query, commandType: CommandType.Text).ToList();
                if (l.Count > 0)
                    return l[0];
                else
                    return default(T);
            }
            catch (Exception ex)
            {
                throw new DbPsglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public T getObject<T>(string query, object parameters)
        {
            var conn = getConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                var l = SqlMapper.Query<T>(conn, query, param: parameters, commandType: CommandType.Text).ToList();

                if (l.Count > 0)
                    return l[0];
                else
                    return default(T);
            }
            catch (Exception ex)
            {
                throw new DbPsglException("Error al ejecutar sql", ex);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
*/