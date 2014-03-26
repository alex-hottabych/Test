
using ConsoleApplication1.Annotations;

namespace ConsoleApplication1.NewFolder1.NewFolder1
{
    [UsedImplicitly]
    public class Class1
    {
        public void Foo()
        {
            string a = Resource1.Class1_Foo_Hello;

        }

        SomeObject foo()
        {
            var data = new SomeObject();
            data.Property = "something";
            return data;
        }

        private class SomeObject
        {
            public string Property { get; set; }
        }


        SomeObject Doo()
        {
            return new SomeObject
            {
                Property = "something"
            };
        }
    }
}