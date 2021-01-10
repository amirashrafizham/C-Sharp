using System;

namespace Revision_Class
{
    class ItalianChef : Chef //with the colon, it will inherit all the Chef class methods.
    {
        public new void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        //But what if for the Italian chef doesn't make bbq ribs for MakeSpecialDish, how do we change it?
        //This is called Overwriting a Method
        //Therefore, in the Chef class, you must include the 'virtual' keyword
        //Then use the 'override' keyword in the ItalianChef class
        
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}