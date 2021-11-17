using System;

namespace dz6._1
{
       
    
        abstract class Component
        {
            public abstract void Operation();
        }

        
        class Decorations : Component
        {
            public override void Operation()
            {
                Console.WriteLine("Decorations");
            }
        }

        abstract class Decorator : Component
        {
            protected Component component;

            public void SetComponent(Component component)
            {
                this.component = component;
            }
            public override void Operation()
            {
                if (component != null)
                {
                    component.Operation();
                }
            }
        }

        // "ConcreteDecoratorA"
        class Toy : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("Toy added");
            }
        }

 
        class Garland : Decorator
        {
            public override void Operation()
            {
                base.Operation();
                Console.WriteLine("Garland");
                Glow();
            }

            static void Glow()
            {
                Console.WriteLine("The garland glows");
            }
        }
        class Tree
        {
            static void Main()
            {
                
                Decorations c = new Decorations();
                Toy t1 = new Toy();
                Toy t2 = new Toy();
                Toy t3 = new Toy();
                Garland g1 = new Garland();

               
                t1.SetComponent(c);
                t2.SetComponent(t1);
                t3.SetComponent(t2);
                g1.SetComponent(t3);

                g1.Operation();
                
                

               
                Console.Read();
            }
        }
}
