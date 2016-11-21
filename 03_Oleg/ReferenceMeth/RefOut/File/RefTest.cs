using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefOut.File
{
    class RefTest
    {
        // Данный метод изменяет свой аргумент с помощью модификатора ref.
        // Модификатор ref указывается как при объявлении, так и привызове метода
        public void Sqr (ref int i) // позволяет передавать обычный тип по ссылке 
        { //ref указывается перед объявлением параметра в методе Sqr
            i = i * i; 
        }
    }
}
