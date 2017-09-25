using System;
using System.Collections.Generic;
using System.Text;
using Conversacion01;

namespace Conversacion01
{
    class Lenguaje
    {
        public List<Nodo> NodosLenguaje;

        public Lenguaje()
        {
            NodosLenguaje = new List<Nodo>();

            Dictionary<int, List<string>> _Diccionario01 = new Dictionary<int, List<string>>();
            _Diccionario01.Add(0, new List<string> { "hola" });
            _Diccionario01.Add(1, new List<string>{ "entrada", "entrar"});
            _Diccionario01.Add(2, new List<string> { "salida", "salir" });
            _Diccionario01.Add(3, new List<string> { "quién", "consulta"});
            _Diccionario01.Add(4, new List<string> { "quiénes", "cuántos"});
            NodosLenguaje.Add(new Nodo(0, Nodo.TiposNodo.Pregunta, "Hola, ¿qué necesitas?", _Diccionario01));

            Dictionary<int, List<string>> _Diccionario02 = new Dictionary<int, List<string>>();        
            _Diccionario02.Add(7, Presencia.ListaHabitantes());            
            NodosLenguaje.Add(new Nodo(1, Nodo.TiposNodo.ConsultaNombre, "¿A quién?", _Diccionario02));

        }
    }
}

