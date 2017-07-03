using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ConsoleApplication1
{
    class Reflector
    {
        public Reflector() { }
        public void Write_to_file(string className)
        {
            Type type = Type.GetType(className);
            using (StreamWriter stw = new StreamWriter(@"D:\2-й курс\2-й семестр\C#\Lab5._Делегаты\ConsoleApplication1\ConsoleApplication1\text.txt"))
            {
                stw.WriteLine("\tAssebly: ", type.Assembly);
                stw.WriteLine("\tAttributes: ", type.Attributes);
                stw.WriteLine("\tFull Name: ", type.FullName);
                stw.WriteLine("\tProperty: ");
                var property = GetProperties(className);
                    foreach (var item in property)
                    {
                        stw.WriteLine(item.ToString());
                    }
                var pub_method = Publick_methods(className);
                stw.WriteLine("\tInformation for methods:");
                    foreach (var item in pub_method)
                    {
                        stw.WriteLine(item);
                    }
                stw.WriteLine("\tFields");
                var fields = GetFields(className);
                    foreach (var item in fields)
                    {
                        stw.WriteLine(item);
                    }
                var interfaces = GetInterfaces(className);
                stw.WriteLine("\tInterfaces");
                foreach (var item in interfaces)
                {
                    stw.WriteLine(item);
                }
            }
        }
        public IEnumerable<MethodInfo> Publick_methods(string className)
        {
            Type type = Type.GetType(className);
            return type.GetMethods();
        }

        public IEnumerable<PropertyInfo> GetProperties(string className)
        {
            Type type = Type.GetType(className);
            return type.GetProperties();
        }
        public IEnumerable<FieldInfo> GetFields(string className)
        {
            Type type = Type.GetType(className);
            return type.GetFields();
        }
        public IEnumerable<Type> GetInterfaces(string className)
        {
            Type type = Type.GetType(className);
            return type.GetInterfaces();
        }
        public IEnumerable<MethodInfo> GetParametersOfMetods(string className, string typeParam)
        {
            List<MethodInfo> metods = new List<MethodInfo>();
            Type type = Type.GetType(className);
            foreach (var method in type.GetMethods())
            {
                foreach (var param in method.GetParameters())
                {
                    if (Equals(param.ParameterType.ToString(), typeParam))
                    {
                        metods.Add(method);
                    }
                }
            }
            return metods;
        }
        
    }
}