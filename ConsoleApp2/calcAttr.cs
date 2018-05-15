using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class calcAttr : Attribute // создаём собственный атрибут наследуясь от стандартного класса
    {
        public int Count { get; set; } // создаём своё свойство которое будет содержать атрибут
                                       // можно описать несколько свойств но для примера создаётся только одно
    }
}
