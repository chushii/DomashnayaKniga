using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnayaKniga
{
    public class QueryBuilder()
    {
        private string? type, result;

        public void Reset()
        {
            type = null; result = null;
        }
        
        public void SetType(string t)
        {
            switch (t)
            {
                case "Выборка":
                    result += "SELECT ";
                    type = "FROM ";
                    break;
                case "Изменение":
                    result += "UPDATE ";
                    type += "TABLE ";
                    break;
                case "Вставка":
                    result += "INSERT ";
                    type = "INTO ";
                    break;
                case "Удаление":
                    result += "DELETE ";
                    type = "FROM ";
                    break;
            }
        }

        public void SetTable(string table)
        {
            result += type;
            switch (table)
            {
                case "Пользователи":
                    result += "Users";
                    break;
                case "Книги":
                    result += "Books";
                    break;
                case "Комнаты":
                    result += "Rooms";
                    break;
                case "Компьютеры":
                    result += "Computers";
                    break;
            }
        }
        
        public void SetColumns(string columns)
        {
            if (type == "FROM ")
            {
                if (columns == "") result += "* ";
                else result += columns + " ";
            }
            else
            {
                if (columns == "") return;
                else result += $" ({columns}) ";
            }
        }

        public void SetWhere(string where)
        {
            if (where == "") return;
            result += " WHERE " + where;
        }

        public void SetOrder(string order, string ascdesc)
        {
            if (order == "") return;
            result += " ORDER BY " + order;
            if (ascdesc == "По убыванию") result += " DESC";
        }

        public void SetValues(string values)
        {
            if (values == "") return;
            if (type == "TABLE ") result += " SET " + values;
            else
            {
                if (values.Split()[0].ToLower() == "select") result += values;
                else
                {
                    result += "VALUES ";
                    string[] lines = values.Split(
                        new string[] { Environment.NewLine },
                        StringSplitOptions.None
                    );
                    foreach (string line in lines)
                    {
                        result += $"({line}), ";
                    }
                    if (result != null) result = result.Substring(0, result.Length - 2);
                }
            }
        }

        public string Result() { return $"{result};" ?? "missingno"; }
    }
}
