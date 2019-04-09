using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo
{
    #region Constructor Injection

    /// <summary>
    /// 
    /// </summary>
    public interface IText
    {
        void Print();
    }
    public class FormatClass : IText
    {
        public void Print()
        {
            Console.WriteLine("Here is a text format");
        }
    }

    /// <summary>
    /// Pass class as constructor parameters and use it that class
    /// </summary>
    public class ConstructorInjection
    {
        private IText _text;
        //constructor
        public ConstructorInjection(IText text)
        {
            this._text = text;
        }
        //print the format
        public void Print()
        {
            _text.Print();
        }
    }
    #endregion 

    #region Property Injection
    public interface INotificationAction
    {
        void ActionOnNotification(string message);
    }

    /// <summary>
    /// Class is useful to sent notification
    /// </summary>
    class NotificationAction
    {
        INotificationAction task = null;
        /// <summary>
        /// This is useful to sent notification message based on action.
        /// </summary>
        /// <param name="notificationAction"></param>
        /// <param name="message"></param>
        public void Notify(INotificationAction notificationAction,  string message)
        {
            this.task = notificationAction ;
            task.ActionOnNotification(message);
        }
    }

    class EventLogWriter : INotificationAction
    {
        public void ActionOnNotification(string message)
        {
            Console.WriteLine(message);
        }
    }
    
    #endregion

    #region MethodInjection
    public interface ISet
    {
        void Print();
    }
    public class Service:ISet
    {
        public void Print()
        {
 	        Console.WriteLine("Print....");
        }
    }

    public class Client
    {
        private ISet _set;
        public void Run(ISet service)
        {
            this._set = service;
            Console.WriteLine("Start...");
            this._set.Print();
        }
    }

 
    #endregion

    public class DISample
    {
        /// <summary>
        /// Implements the constructor injection
        /// </summary>
        public static void CallConstructorInjection()
        {
            // By passing the services that implemented the text interface the builder assembled the dependencies.
            // Need to pass the specified value at the time of object creation. 
            // We can use the injection component anywhere within the class. 
            // It addresses the most common scenario where a class requires one or more dependencies.
            ConstructorInjection constrcutorInjectObj = new ConstructorInjection(new FormatClass());
            constrcutorInjectObj.Print();
        }

        /// <summary>
        /// Implements Property injection
        /// </summary>
        public static void CallPropertyInjection()
        {
            EventLogWriter logWriterObj = new EventLogWriter();
            NotificationAction notificationActionObj = new NotificationAction();
            //You cannot control when the dependency is set at all, it can be changed at any point in the object's lifetime.
            notificationActionObj.Notify(logWriterObj, "Hello Action");            
        }

        /// <summary>
        /// Pass the dependency in the method only
        /// </summary>
        public static void ClassMethodInjection()
        {
            Client clientObj = new Client();
            // Class with a method that has a dependency
            clientObj.Run(new Service());            
        }
    }
}
