using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{//https://habr.com/post/172859/
    [calcAttr( Count = 1 )]
    class безумие
    {
        public int GetInt()
        {
            var type = this.GetType(); // получение описания типа
            if (Attribute.IsDefined(type, typeof(calcAttr))) // проверка на существование атрибута
            {
                var attributeValue = Attribute.GetCustomAttribute(type, typeof(calcAttr)) as calcAttr; // получаем значение атрибута
                return attributeValue.Count; // используем значение атрибута для формирования результата
            }
            return 0;
        }
    }
}
