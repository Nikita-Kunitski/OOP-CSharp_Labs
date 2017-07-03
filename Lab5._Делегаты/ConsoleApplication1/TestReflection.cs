using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;


namespace TestReflection
{
    public class Reflector
    {
        public Reflector()
        {

        }

        public void OutputInfoToFile(string className)
        {
            Type type = Type.GetType(className);
            using (StreamWriter sw = new StreamWriter(@"InfoAboutClass.txt"))
            {
                sw.WriteLine($"Assembly: {type.Assembly}");
                sw.WriteLine($"Attributes: {type.Attributes}");
                sw.WriteLine($"Full name: {type.FullName}");
                sw.WriteLine($"Methods:");
                foreach (var method in PopAllPublicMethods(className))
                {
                    string mod = string.Empty;
                    if (method.IsPrivate)
                    {
                        mod += "private ";
                    }
                    if (method.IsPublic)
                    {
                        mod += "public ";
                    }
                    if (method.IsStatic)
                    {
                        mod += "static ";
                    }
                    if (method.IsVirtual)
                    {
                        mod += "virtual ";
                    }
                    sw.WriteLine(mod + method);
                }
                sw.WriteLine($"Fields:");
                foreach (var field in GetInfoAboutFields(className))
                {
                    sw.WriteLine(field);
                }
                sw.WriteLine($"Properties:");
                foreach (var property in GetInfoAboutProperties(className))
                {
                    sw.WriteLine(property);
                }
                sw.WriteLine($"Implemented interfaces:");
                foreach (var Interface in GetAllImplementedInterfaces(className))
                {
                    sw.WriteLine(Interface);
                }
            }
        }

        public IEnumerable<MethodInfo> PopAllPublicMethods(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                return type.GetMethods();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public IEnumerable<PropertyInfo> GetInfoAboutProperties(string className)
        {
            Type type = Type.GetType(className);
            return type.GetProperties();
        }

        public IEnumerable<FieldInfo> GetInfoAboutFields(string className)
        {
            Type type = Type.GetType(className);
            return type.GetFields();
        }

        public IEnumerable<Type> GetAllImplementedInterfaces(string className)
        {
            Type type = Type.GetType(className);
            return type.GetInterfaces();
        }
        /// <summary>
        /// Получает список методов с заданным пользователем параметром
        /// </summary>
        /// <param name="className"></param>
        /// <param name="paramType"></param>
        public IEnumerable<MethodInfo> GetMethods(string className, string paramType)
        {
            List<MethodInfo> methods = new List<MethodInfo>();
            Type type = Type.GetType(className);
            foreach (var method in type.GetMethods())
            {
                foreach (var param in method.GetParameters())
                {
                    if (param.ParameterType.ToString() == paramType)
                    {
                        methods.Add(method);
                        break;
                    }
                }
            }
            return methods;
        }
        /// <summary>
        /// вызов неизвестного метода
        /// </summary>
        /// <param name="className"></param>
        /// <param name="methodName"></param>
        public void CallUnfamiliarMethod(string className, string methodName, object invokeObj)
        {
            Type type = Type.GetType(className);
            MethodInfo invokeMethod = type.GetMethod(methodName);
            List<object> Params = new List<object>();
            try
            {
                using (StreamReader sr = new StreamReader(@"Params.txt"))
                {
                    StringBuilder sb = new StringBuilder();
                    for (; !sr.EndOfStream;)
                    {
                        
                        char c;
                        if (char.IsWhiteSpace((c = Convert.ToChar(sr.Read()))))
                        {
                            int param;
                            if (int.TryParse(sb.ToString(), out param))
                            {
                                Params.Add(param);
                            }
                            sb.Clear();
                            continue;
                        }
                        sb.Append(c);
                    }
                    Params.Add(Convert.ToInt32(sb.ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            invokeMethod.Invoke(invokeObj, Params.ToArray());
        }

    }
}

