using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    #region AbstractFactory pattern
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    abstract class AbstractProductA
    {
    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ConcreateFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            // returning the instance of non-abstract class (ProductA1)
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            // returning the instance of non-abstract class (ProductB1)
            return new ProductB1();
        }
    }

    class ConcreateFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    class ProductA1: AbstractProductA
    { }

    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class ProductA2: AbstractProductA
    { }

    class ProductB2:AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class AbstractFactoryClient
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        // constructor
        public AbstractFactoryClient(AbstractFactory factory)
        {
            // Invoking abstract method and assiging to abstract class
            _abstractProductA = factory.CreateProductA();
            _abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
    #endregion

    #region Factory method pattern
    abstract class ProductFM
    { }

    class ConcreteProductA: ProductFM
    { }

    class ConcreteProductB : ProductFM
    { }

    abstract class Creator
    {
        public abstract ProductFM FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override ProductFM FactoryMethod()
        {
            // returning the instance of concrete class A
            return new ConcreteProductA();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override ProductFM FactoryMethod()
        {
            // Returning the instance of concrete class B
            return new ConcreteProductB();
        }
    }
    #endregion

    #region Singleton pattern
    /// <summary>
    /// This class is useful to create singleton 
    /// </summary>
    class Singleton
    {
        // static variable with a type of singleton class
        private static Singleton _instance;

        // constructor
        protected Singleton()
        {}

        /// <summary>
        /// return instance of Singleton class
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            if (_instance == null )
	        {
                // creating an insance of singleton class only once
		        _instance = new Singleton();
	        }
            return _instance ;
        }
    }    
    #endregion
    
    public class DesignPatternDemo
    {
        /// <summary>
        /// Provide an interface for creating families of 
        /// related or dependent objects without specifying their concrete classes
        /// </summary>
        public static void AbstractFactoryPatternDemo()
        {
            // Creating instance of concreate class (non-abstract class) and assigning to abstract class
            AbstractFactory factory1 = new ConcreateFactory1();
            AbstractFactoryClient client = new AbstractFactoryClient(factory1);
            client.Run();

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreateFactory2();
            AbstractFactoryClient client2 = new AbstractFactoryClient(factory2);
            client2.Run();
        }

        /// <summary>
        /// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
        /// Factory method lets a class defer instantiation to subclasses.
        /// </summary>
        public static void FactoryMethodDemo()
        {
            // An array of creators
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // iteratee over creators and create products
            foreach (Creator creator in creators)
            {
                ProductFM product = creator.FactoryMethod();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }

        /// <summary>
        /// Ensure a class has only one instance and provide a global point of access to it.
        /// </summary>
        public static void SingletonPatternDemo()
        {
            // when we create instance for first time then it calls instance property and returns the single instance 
            Singleton _instance1 = Singleton.Instance();

            // As it is already created then it will simply return the insance of singleton class
            Singleton _instance2 = Singleton.Instance();
        }
    }
}
