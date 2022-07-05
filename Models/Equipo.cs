using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data.SqlClient;

namespace TP6_Ayala_LopezAbraham.Models;

public class Equipo{
    private string _Nombre,_Escudo,_Camiseta,_Continente;
    private int _IdEquipo,_CopasGanadas;

    public Equipo()
    {}

    public Equipo(string nombre, string escudo, string camiseta, string continente, int idEquipo, int copasGanadas)
    {
        _Nombre=nombre;
        _Escudo=escudo;
        _Camiseta=camiseta;
        _Continente=continente;
        _IdEquipo=idEquipo;
        _CopasGanadas=copasGanadas;
    }

    public string Nombre
    {
        get{return _Nombre;}
        set{_Nombre = value;}
    }
    public string Escudo
    {
        get {return _Escudo;}
        set {_Escudo=value;}
    }
    public string Camiseta
    {
        get {return _Camiseta;}
        set {_Camiseta=value;}
    }
    public string Continente
    {
        get {return _Continente;}
        set {_Continente=value;}
    }
    public int IdEquipo
    {
        get {return _IdEquipo;}
        set {_IdEquipo = value;}
    }
    public int CopasGanadas
    {
        get {return _CopasGanadas;}
        set {_CopasGanadas = value;}
    }
}

