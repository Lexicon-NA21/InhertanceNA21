using System;
using System.Collections.Generic;
using System.Text;

namespace InhertanceNA21
{
    class A
    {
        public string Name { get; set; }
    } 
    
    class B : A
    {
        public int Age { get; set; }
    } 
    
    class C : B
    {
        public string Adress { get; set; }
    }
}
