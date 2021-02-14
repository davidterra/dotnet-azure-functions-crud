using Microsoft.WindowsAzure.Storage.Table;

namespace MyFunctionProj
{
     public class Person : TableEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person() { }
    }
}