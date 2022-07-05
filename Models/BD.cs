using TP6_Ayala_LopezAbraham.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data.SqlClient;
using Dapper;

namespace TP6_Ayala_LopezAbraham.Models;

public static class BD{
    private static string _connectionString= @"Server=A-CIDI-127;DataBase=Qatar2022;Trusted_Connection=true;";
    public static int AgregarJugador(Jugador Jug)
    {
        int resultado = 0;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "INSERT INTO [Jugadores] (Nombre, Foto, EquipoActual, FechaNacimiento) VALUES (@pNombre, @pFoto, @pEquipoActual, @pFechaNacimiento)";
            resultado = db.Execute(sql, new{pNombre = Jug.Nombre, pFoto = Jug.Foto, pEquipoActual = Jug.EquipoActual, pFechaNacimiento = Jug.FechaNacimiento});
        }
        return resultado;
    }

    public static int EliminarJugador(int IdJugador)
    {
        int resultado = 0;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "DELETE * FROM [Jugadores] WHERE [Jugadores].[IdJugador] = @pIdJugador";
            resultado = db.Execute(sql, new{pIdJugador = IdJugador});
        }
        return resultado;
    }

    public static Equipo VerInfoEquipo(int IdEquipo)
    {
        Equipo eq = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Equipos WHERE Equipos.IdEquipo = @pIdEquipo";
            eq = db.QueryFirstOrDefault<Equipo>(sql, new {pIdEquipo = IdEquipo});
        }
        return eq;
    }

    public static Jugador VerInfoJugador(int IdJugador)
    {
        Jugador Jug = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM [Jugadores] WHERE [Jugadores].[IdJugador] = @pIdJugador";
            Jug = db.QueryFirstOrDefault<Jugador>(sql, new {pIdJugador = IdJugador});
        }
        return Jug;
    }

    public static List<Equipo> ListarEquipos()
    {
        List<Equipo> ListaEquipos=new List<Equipo>();
        using(SqlConnection db= new SqlConnection(_connectionString)){
            string sql= "SELECT * FROM [Equipos]";
            ListaEquipos = db.Query<Equipo>(sql).ToList();
        }
        return ListaEquipos;
    }

    public static List<Jugador> ListarJugadores(int IdEquipo)
    {
        List<Jugador> ListaJugadores=new List<Jugador>();
        using(SqlConnection db= new SqlConnection(_connectionString)){
            string sql= "SELECT * FROM [Jugadores] WHERE [Jugadores].[IdEquipo] = @pIdEquipo";
            ListaJugadores = db.Query<Jugador>(sql, new{pIdEquipo = IdEquipo}).ToList();
        }
        return ListaJugadores;
    }
}