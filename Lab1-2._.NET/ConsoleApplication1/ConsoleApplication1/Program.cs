using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Polyhedron
            {
            public int vertex { get; set; }
            public int edge { get; set; }
            protected static int object_counter = 0;
            protected readonly int ID;
            public Polyhedron(int val_vertex, int val_edge)
            {
                vertex = val_vertex;
                edge = val_edge;
                ID = edge * vertex;
                object_counter++;
            }
            static Polyhedron()
            {
                object_counter++;
                Console.WriteLine("Call static constrictor");
            }
            static void information()
            {
                Console.WriteLine("Object counter:" + object_counter);
            }
            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }
                Polyhedron p = obj as Polyhedron;
                if ((object)p == null)
                {
                    return false;
                }
                return (vertex == p.vertex) && (edge== p.edge);
            }

            public override int GetHashCode()
            {
                return vertex ^ edge;
            }
        };
        static void Main(string[] args)
        {
            int edge = 5, value = 15;
            MathObject math=new MathObject();
            Console.WriteLine("Area="+math.Area(ref edge,ref value));
            Console.WriteLine("Perimetr=" + math.Perimetr(ref edge, ref value));
            Polyhedron obj=new Polyhedron(4,12);

                    int size_box_height, size_box_length;
                    int size_obj_=obj.edge;
                    Console.WriteLine("Enter size box height:");
            Console.ReadKey();
            size_box_height = Console.Read();
            
                    Console.WriteLine("Enter size box length:");
            Console.ReadKey();
            size_box_length = Console.Read();
            Console.ReadKey();
            Console.ReadKey();
            math.box(ref size_box_length,ref size_box_height,ref size_obj_);
            
        }
    }
}
