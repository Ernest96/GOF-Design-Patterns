using Builder;
using Builder.Classic;
using Builder.Classic.Common;
using FactoryMethod.Builder.Fluent;
using IPP.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using IPP.Composite;
using IPP.Composite.Builder;
using IPP.Decorator;
//using IPP.Bridge;
using IPP.Adapter;
using IPP.Proxy;
using IPP.Fasade;
using IPP.FlyWeight;
using IPP.Command;
using IPP.Strategy;
using IPP.Visitor;
using IPP.Mediator;



namespace IPP
{
    class Explorer
    {
        static void Main(string[] args)
        {
            //Hero h = new Ninja();
            //HeroDecorator hd1 = new Knife();
            //HeroDecorator hd3 = new Knife();
            //HeroDecorator hd2 = new Armor();


            //hd1.SetComponent(h);
            //hd2.SetComponent(hd1);
            //hd3.SetComponent(hd2);
            //var a = hd3.getArmor();
            //var b = hd3.getDamage();



            //TV receiver = new TV();
            //Remote invoker = new Remote();
            //Commanda command = new VolumeUp(receiver);

            //invoker.SetCommand(command);
            //invoker.Invoke();


            //Context cont = new Context();
            //Strategy.Strategy qstrategy = new QuickSort();
            //Strategy.Strategy istrategy = new InsertionSort();

            //cont.SetStrategy(qstrategy);

            Visitor.Visitor v1 = new ConcreteVisitorA();
            Visitor.Visitor v2 = new ConcreteVisitorB();
            Visitor.Person s = new Student();
            Visitor.Person p = new Profesor();

            ObjectStructure o = new ObjectStructure();
            o.Attach(s);
            o.Attach(p);

            o.Accept(v1);
            o.Accept(v2);

            ChatMediator m = new ChatMediator();
            User1 u1 = new User1(m);
            User2 u2 = new User2(m);

            m.user1 = new User1(m);
            m.user2 = new User2(m);





            Console.ReadLine();


        }
    }
}
