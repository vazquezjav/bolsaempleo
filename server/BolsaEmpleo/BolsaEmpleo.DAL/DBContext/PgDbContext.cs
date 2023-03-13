﻿using BolsaEmpleo.EXCEPTIONS;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaEmpleo.DAL.DBContext {
    public class PgDbContext : IDbContext {
        public readonly string _connectionString;

        public PgDbContext(IConfiguration configuration) {
            _connectionString = configuration.GetConnectionString("PostgresqlDBConnection");
        }
        public void excecuteQuery(string query) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }

                SqlMapper.Query(conn, query, commandType: CommandType.Text);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public void excecuteQuery(string query, object parameters) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }

                SqlMapper.Query(conn, query, param: parameters, commandType: CommandType.Text, commandTimeout: 800);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public async Task excecuteQueryAsync(string query) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }

                SqlMapper.QueryAsync(conn, query, commandType: CommandType.Text);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public async Task excecuteQueryAsync(string query, object parameters) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed) {
                    conn.Open();
                }

                await SqlMapper.QueryAsync(conn, query, param: parameters, commandType: CommandType.Text);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public List<T> getList<T>(string query) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return SqlMapper.Query<T>(conn, query, commandType: CommandType.Text, commandTimeout: 3600).ToList();
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public List<T> getList<T>(string query, object parameters) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return SqlMapper.Query<T>(conn, query, param: parameters, commandType: CommandType.Text,commandTimeout:400).ToList();
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public T getObject<T>(string query) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                var l = SqlMapper.Query<T>(conn, query, commandType: CommandType.Text).ToList();
                if (l.Count > 0)
                    return l[0];
                else
                    return default(T);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public T getObject<T>(string query, object parameters) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                var l = SqlMapper.Query<T>(conn, query, param: parameters, commandType: CommandType.Text).ToList();

                if (l.Count > 0)
                    return l[0];
                else
                    return default(T);
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar sql: "+ex.Message, ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }

        public void excecuteProcedure(string query , Object parameters) {
            var conn = new NpgsqlConnection(_connectionString);
            try {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlMapper.Query(conn, query, param: parameters, commandType: CommandType.Text, commandTimeout: 800);                
            } catch (Exception ex) {
                throw new DbPsglException("Error al ejecutar procedure", ex);
            } finally {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
