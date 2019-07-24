using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_SQL_Management_light
{

    static class WortReserv
    {

        public struct ReservWord
        {
            public string Word;
            public Color Color;
            public ReservWord(string word, Color color)
            {
                this.Word = word;
                this.Color = color;
            }
        }

        public static readonly List<ReservWord> CommandMapping2 = new List<ReservWord>()
        {
            new ReservWord( "ADD", Color.Blue),
            new ReservWord( "ALTER", Color.Blue),
            new ReservWord( "ANSI_NULLS", Color.Blue),
            new ReservWord( "AS", Color.Blue),
            new ReservWord( "BEGIN", Color.Blue),
            new ReservWord( "BY", Color.Blue),
            new ReservWord( "CLOSE", Color.Blue),
            new ReservWord( "CREATE", Color.Blue),
            new ReservWord( "CONSTRAINT", Color.Blue),
            new ReservWord( "CURSOR", Color.Blue),
            new ReservWord( "DATA", Color.Blue),
            new ReservWord( "DATABASE", Color.Blue),
            new ReservWord( "DATETIME", Color.Blue),
            new ReservWord( "DEALLOCATE", Color.Blue),
            new ReservWord( "DECLARE", Color.Blue),
            new ReservWord( "DEFAULT", Color.Blue),
            new ReservWord( "DELETE", Color.Blue),
            new ReservWord( "DROP", Color.Blue),
            new ReservWord( "ELSE", Color.Blue),
            new ReservWord( "END", Color.Blue),
            new ReservWord( "FETCH", Color.Blue),
            new ReservWord( "FLOAT", Color.Blue),
            new ReservWord( "FROM", Color.Blue),
            new ReservWord( "FOR", Color.Blue),
            new ReservWord( "FUNCTION", Color.Blue),
            new ReservWord( "HAVING", Color.Blue),
            new ReservWord( "IDENTITY", Color.Blue),
            new ReservWord( "IF", Color.Blue),
            new ReservWord( "INT", Color.Blue),
            new ReservWord( "GO", Color.Blue),
            new ReservWord( "GROUP", Color.Blue),
            new ReservWord( "NEXT", Color.Blue),
            new ReservWord( "NOCHECK", Color.Blue),
            new ReservWord( "OFF", Color.Blue),
            new ReservWord( "ON", Color.Blue),
            new ReservWord( "OPEN", Color.Blue),
            new ReservWord( "ORDER", Color.Blue),
            new ReservWord( "QUOTED_IDENTIFIER", Color.Blue),
            new ReservWord( "RETURN", Color.Blue),
            new ReservWord( "RETURNS", Color.Blue),
            new ReservWord( "SELECT", Color.Blue),
            new ReservWord( "SET", Color.Blue),
            new ReservWord( "TABLE", Color.Blue),
            new ReservWord( "TOP", Color.Blue),
            new ReservWord( "UNION", Color.Blue),
            new ReservWord( "WHERE", Color.Blue),
            new ReservWord( "WITH" , Color.Blue),
            /////////////////////////////////////////////////////////////////
            new ReservWord( "+", Color.Gray),
            new ReservWord( "=", Color.Gray),
            new ReservWord( ">", Color.Gray),
            new ReservWord( "<", Color.Gray),
            new ReservWord( "(", Color.Gray),
            new ReservWord( ")", Color.Gray),
            new ReservWord( "AND", Color.Gray),
            new ReservWord( "JOIN", Color.Gray),
            new ReservWord( "LEFT", Color.Gray),
            new ReservWord( "NOT", Color.Gray),
            new ReservWord( "NULL", Color.Gray),
            new ReservWord( "OR", Color.Gray),
            //////////////////////////////////////////////////////////////////
            new ReservWord( "@@FETCH_STATUS", Color.Magenta ),
            new ReservWord( "ISNULL", Color.Magenta ),
            new ReservWord( "COLLATE", Color.Magenta ),
            new ReservWord( "getdate", Color.Magenta ),
            new ReservWord( "suser_sname", Color.Magenta ),
            new ReservWord( "host_name", Color.Magenta ),
            new ReservWord( "app_name", Color.Magenta ),
            new ReservWord( "UPDATE", Color.Magenta ),
            new ReservWord( "SUM", Color.Magenta )
        };
    }
}
