using Castle.DynamicProxy;
using DesignPatternsPractice.AbstractFactory;
using DesignPatternsPractice.Adapter;
using DesignPatternsPractice.Bridge;
using DesignPatternsPractice.Builder;
using DesignPatternsPractice.ChainOfResponsibility;
using DesignPatternsPractice.Command;
using DesignPatternsPractice.Composite;
using DesignPatternsPractice.Decorator;
using DesignPatternsPractice.Facade;
using DesignPatternsPractice.FactoryMethod.Factory;
using DesignPatternsPractice.FactoryMethod.SimpleFactory;
using DesignPatternsPractice.Flyweight;
using DesignPatternsPractice.Interpreter;
using DesignPatternsPractice.Iterator;
using DesignPatternsPractice.Mediator;
using DesignPatternsPractice.Memento;
using DesignPatternsPractice.OBServer;
using DesignPatternsPractice.Prototype;
using DesignPatternsPractice.Proxy;
using DesignPatternsPractice.Singleton;
using DesignPatternsPractice.State;
using DesignPatternsPractice.Strategy;
using DesignPatternsPractice.Template;
using DesignPatternsPractice.Visitor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 工厂方法
            //SimpleFactory();
            //FactoryMethod();
            #endregion

            #region 抽象工厂
            //AbstractFactory();
            //AbstractFactoryWithSimpleFactory();
            #endregion

            #region 生成器
            //Builder();
            #endregion

            #region 原型
            //Prototype();
            //PrototypeManager();
            #endregion

            #region 单件
            //Singleton();
            #endregion

            #region 适配器
            //ClassAdapter();
            //ObjAdapter();
            //DoubleAdapter();
            #endregion

            #region 桥接
            //Bridge();
            #endregion

            #region 组合
            //Composite();
            #endregion

            #region 装饰
            //Decorator();
            #endregion

            #region 外观
            //Facade();
            #endregion

            #region 享元
            //SimpleFlyweight();
            //Flyweight();
            //Intern();
            #endregion

            #region 代理
            //StaticProxy();
            //DynamicProxyByRemoting();
            //DynamicProxyByCastle();
            #endregion

            #region 职责链
            //ChainOfResponsibility();
            #endregion

            #region 命令
            //Command();
            //MacorCommand();
            #endregion

            #region 解释器
            //Interpreter();
            #endregion

            #region 迭代器
            //Iterator();
            //ForeachDemo();
            #endregion

            #region 中介者
            //Mediator();
            #endregion

            #region 备忘录
            //Memento();
            //MementoWithCommand();
            #endregion

            #region 观察者
            //OBServer();
            #endregion

            #region 状态
            //State();
            #endregion

            #region 策略
            //Strategy();
            #endregion

            #region 模板方法
            //TemplateMethod();
            #endregion

            #region 访问者
            //Visitor();
            #endregion
        }

        #region 工厂方法
        /// <summary>
        /// 参数化工厂方法（简单工厂）
        /// </summary>
        static void SimpleFactory()
        {
            //创建工厂
            MouseFactory factory = new MouseFactory();

            //通过工厂生产实体
            //IMouse mouseA = factory.CreateMouse("罗技");
            //IMouse mouseB = factory.CreateMouse("雷蛇");
            IMouse mouseA = factory.CreateMouse(MouseBrandConst.Logitech);
            IMouse mouseB = factory.CreateMouse(MouseBrandConst.Raze);

            Console.WriteLine($"参数化工厂方法（简单工厂）{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"MouseA的品牌是：{mouseA.GetBrand()}");
            Console.WriteLine($"MouseB的品牌是：{mouseB.GetBrand()}");
            Console.ReadKey();
        }

        /// <summary>
        /// 非参数化工厂方法（工厂模式）
        /// </summary>
        static void FactoryMethod()
        {
            //创建工厂
            IMouseFactory logitechFactory = new LogitechMouseFactory();
            IMouseFactory razeFactory = new RazeMouseFactory();

            //通过工厂生产实体
            IMouse mouseA = logitechFactory.CreateMouse();
            IMouse mouseB = razeFactory.CreateMouse();

            Console.WriteLine($"非参数化工厂方法（工厂模式）{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"MouseA的品牌是：{mouseA.GetBrand()}");
            Console.WriteLine($"MouseB的品牌是：{mouseB.GetBrand()}");
            Console.ReadKey();
        }
        #endregion

        #region 抽象工厂模式
        /// <summary>
        /// 抽象工厂
        /// </summary>
        static void AbstractFactory()
        {
            //创建抽象工厂
            IFactory factory = new LogitechFactory();
            //IFactory factory = new RazeFactory();

            //通过工厂生产产品实体
            IMouse mouse = factory.CreateMouse();
            IKeyBoard keyboard = factory.CreateKeyboard();

            Console.WriteLine($"抽象工厂{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"当前工厂生产的鼠标是：{mouse.GetBrand()}");
            Console.WriteLine($"当前工厂生产的键盘是：{keyboard.GetBrand()}");
            Console.ReadKey();
        }

        /// <summary>
        /// 抽象工厂+简单工厂
        /// </summary>
        static void AbstractFactoryWithSimpleFactory()
        {
            //创建抽象工厂
            IFactory factory = new CommonFactory();
            //IFactory factory = new RazeFactory();

            //通过工厂生产产品实体
            IMouse mouse = factory.CreateMouse();
            IKeyBoard keyboard = factory.CreateKeyboard();

            Console.WriteLine($"抽象工厂+简单工厂{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"当前工厂生产的鼠标是：{mouse.GetBrand()}");
            Console.WriteLine($"当前工厂生产的键盘是：{keyboard.GetBrand()}");
            Console.ReadKey();
        }
        #endregion

        #region 生成器
        /// <summary>
        /// 生成器
        /// </summary>
        static void Builder()
        {
            //创建生成器
            IKitBuilder builder = new LogitechKitBuilder();
            //IKitBuilder builder = new RazeKitBuilder();

            //创建导向器
            KitDirector director = new KitDirector();

            //导向器通过注入的生成器创建产品实体
            Kit kit = director.ConstructKit(builder);

            Console.WriteLine($"生成器{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"当前套装内的鼠标是：{kit.Mouse.GetBrand()}");
            Console.WriteLine($"当前套装内的键盘是：{kit.Keyboard.GetBrand()}");
            Console.ReadKey();
        }
        #endregion

        #region 原型
        /// <summary>
        /// 原型
        /// </summary>
        static void Prototype()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Kit kitA = new Kit();
            kitA.Mouse = new LogitechMouse();
            kitA.Keyboard = new LogitechKeyboard();

            stopwatch.Stop();
            double kitACreateTime = stopwatch.Elapsed.TotalMilliseconds;
            stopwatch.Restart();

            Kit kitB = kitA.Clone() as Kit;
            kitB.Mouse = new RazeMouse();
            kitB.Keyboard = new RazeKeyboard();

            stopwatch.Stop();
            double kitBCreateTime = stopwatch.Elapsed.TotalMilliseconds;

            Console.WriteLine($"原型{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"kitA实例 创建用时：{kitACreateTime}ms");
            Console.WriteLine($"kitB实例 创建用时：{kitBCreateTime}ms");
            Console.ReadKey();
        }

        /// <summary>
        /// 原型管理器
        /// </summary>
        static void PrototypeManager()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //创建原型管理器
            PrototypeManager prototypeManager = new PrototypeManager();

            stopwatch.Stop();
            Console.WriteLine($"原型管理器{Environment.NewLine}-------------------------------------------");
            Console.WriteLine($"Load用时：{stopwatch.Elapsed.TotalMilliseconds}ms");
            stopwatch.Restart();

            //创建实例
            Kit kit = prototypeManager.CreateInstance("LogitechKit") as Kit;

            stopwatch.Stop();
            Console.WriteLine($"CreateInstance用时：{stopwatch.Elapsed.TotalMilliseconds}ms");
            Console.WriteLine($"当前套装内的鼠标是：{kit.Mouse.GetBrand()}");
            Console.WriteLine($"当前套装内的键盘是：{kit.Keyboard.GetBrand()}");

            //创建原型并添加至原型管理器
            Kit razeKit = new Kit();
            razeKit.Mouse = new RazeMouse();
            razeKit.Keyboard = new RazeKeyboard();
            prototypeManager.AddPrototype("RazeKit", razeKit);
            Console.ReadKey();
        }
        #endregion

        #region 单件
        /// <summary>
        /// 单件
        /// </summary>
        static void Singleton()
        {
            Console.WriteLine($"单件{Environment.NewLine}-------------------------------------------");
            for (int i = 0; i < 5; i++)
            {
                //异步
                Task.Factory.StartNew(() =>
                {
                    SingletonA.Instance.ShowName();
                    //SingletonB.Instance.ShowName();
                    //SingletonC.Instance.ShowName();
                });
            }

            Console.ReadKey();
        }
        #endregion

        #region 适配器
        /// <summary>
        /// 适配器（类适配）
        /// </summary>
        static void ClassAdapter()
        {
            Console.WriteLine($"适配器（类适配）{Environment.NewLine}-------------------------------------------");
            IFileParseService xmlParseService = new XmlFileParse();
            Console.WriteLine(xmlParseService.Parsing());
            Console.ReadKey();
        }

        /// <summary>
        /// 适配器（对象适配）
        /// </summary>
        static void ObjAdapter()
        {
            Console.WriteLine($"适配器（对象适配）{Environment.NewLine}-------------------------------------------");
            IFileParseTool sqlParseTool = new SqlFileParseTool();
            IFileParseService sqlParseService = new SqlFileParse(sqlParseTool);
            Console.WriteLine(sqlParseService.Parsing());
            Console.ReadKey();
        }

        /// <summary>
        /// 适配器（双向适配）
        /// </summary>
        static void DoubleAdapter()
        {
            Console.WriteLine($"适配器（双向适配）{Environment.NewLine}-------------------------------------------");
            //接口IFileParseService兼容IFileParseTool
            IFileParseService parseService = new FileParse(new XmlFileParseTool());
            Console.WriteLine(parseService.Parsing());

            //接口IFileParseTool兼容IFileParseService
            IFileParseTool parseTool = new FileParse(new TxtFileParse());
            Console.WriteLine(parseTool.FileParsing());

            Console.ReadKey();
        }
        #endregion

        #region 桥接
        /// <summary>
        /// 桥接
        /// </summary>
        static void Bridge()
        {
            Console.WriteLine($"桥接{Environment.NewLine}-------------------------------------------");

            IBrand Logitech = new Logitech();       //创建品牌
            Product mouse = new Mouse(Logitech);    //创建产品
            Console.WriteLine(mouse.ShowMyself());

            IBrand raze = new Raze();               //创建品牌
            Product keyboard = new KeyBoard(raze);  //创建产品
            Console.WriteLine(keyboard.ShowMyself());

            Console.ReadKey();
        }
        #endregion

        #region 组合
        /// <summary>
        /// 组合
        /// </summary>
        static void Composite()
        {
            Console.WriteLine($"组合{Environment.NewLine}-------------------------------------------");

            IFile folder = new Folder("我的文档");
            IFile txtFileA = new Txt("新建文本文档A");
            IFile pngFileA = new Png("QQ截图A");
            IFile folderA = new Folder("新建文件夹A");

            if (folder.IsFolder)
            {
                folder.Add(txtFileA);
                folder.Add(pngFileA);
                folder.Add(folderA);
            }

            IFile txtFileB = new Txt("新建文本文档B");
            IFile pngFileB = new Png("QQ截图B");

            if (folderA.IsFolder)
            {
                folderA.Add(txtFileB);
                folderA.Add(pngFileB);
            }

            Console.WriteLine(folder.ShowMyself());
            Console.ReadKey();
        }
        #endregion

        #region 装饰
        /// <summary>
        /// 装饰
        /// </summary>
        static void Decorator()
        {
            Console.WriteLine($"装饰{Environment.NewLine}-------------------------------------------");

            Component human = new Human();  //一个人
            human = new Clothes(human);     //穿衣服
            human = new Clothes(human);     //在穿一件衣服
            human = new Trouser(human);     //穿裤子
            human = new Shoe(human);        //穿鞋
            //Component human = new Shoe(new Trouser(new Clothes(new Human())));

            Console.WriteLine(human.ShowMyself());
            Console.ReadKey();
        }
        #endregion

        #region 外观
        /// <summary>
        /// 外观
        /// </summary>
        static void Facade()
        {
            Console.WriteLine($"外观{Environment.NewLine}-------------------------------------------");

            AppStoreFacade facade = new AppStoreFacade();

            facade.DownloadAppA();
            Console.ReadKey();

            Console.WriteLine();
            facade.DownloadAppB();
            Console.ReadKey();
        }
        #endregion

        #region 享元
        /// <summary>
        /// 单纯享元
        /// </summary>
        static void SimpleFlyweight()
        {
            Console.WriteLine($"单纯享元{Environment.NewLine}-------------------------------------------");

            IShape circleA = FlyweightFactory.Instance.CreateCircle("很圆的圆形A");
            IShape circleB = FlyweightFactory.Instance.CreateCircle("很圆的圆形A");
            IShape rectangleA = FlyweightFactory.Instance.CreateRectangle("很方的长方形A");


            circleA.Draw(ConsoleColor.Red, 20, 30);
            circleB.Draw(ConsoleColor.Yellow, 10, 130);
            rectangleA.Draw(ConsoleColor.Blue, 25, 60);
            Console.WriteLine($"享元池长度：{FlyweightFactory.Instance.PoolSize}");
            Console.WriteLine($"circleA与circleB是否指向同一内存地址：{object.ReferenceEquals(circleA, circleB)}");
            Console.ReadKey();
        }

        /// <summary>
        /// 复合享元
        /// </summary>
        static void Flyweight()
        {
            Console.WriteLine($"复合享元{Environment.NewLine}-------------------------------------------");

            IShape circleA = FlyweightFactory.Instance.CreateCircle("很圆的圆形B");
            IShape circleB = FlyweightFactory.Instance.CreateCircle("很圆的圆形B");
            IShape rectangleA = FlyweightFactory.Instance.CreateRectangle("很方的长方形B");
            Console.WriteLine("--------------");

            IShape shapCompositeA = FlyweightFactory.Instance.CreateComposite();
            shapCompositeA.Add(circleA);
            shapCompositeA.Add(rectangleA);
            shapCompositeA.Draw(ConsoleColor.Yellow, 10, 130);
            Console.WriteLine("--------------");

            IShape shapCompositeB = FlyweightFactory.Instance.CreateComposite();
            shapCompositeB.Add(circleA);
            shapCompositeB.Add(circleB);
            shapCompositeB.Add(rectangleA);
            shapCompositeB.Draw(ConsoleColor.Blue, 25, 60);
            Console.WriteLine("--------------");

            Console.WriteLine($"享元池长度：{FlyweightFactory.Instance.PoolSize}");
            Console.WriteLine($"shapCompositeA与shapCompositeB是否指向同一内存地址：{object.ReferenceEquals(shapCompositeA, shapCompositeB)}");
            Console.ReadKey();
        }

        /// <summary>
        /// string 暂留
        /// </summary>
        static void Intern()
        {
            Console.WriteLine($"string暂留{Environment.NewLine}-------------------------------------------");

            string a = "test";
            string b = "test";
            string c = "TEST".ToLower();
            string d = "te" + "st";
            string x = "te";
            string y = "st";
            string e = x + "st";
            string f = x + y;

            Console.WriteLine(object.ReferenceEquals(a, b));                    //True;
            Console.WriteLine(object.ReferenceEquals(a, c));                    //False;
            Console.WriteLine(object.ReferenceEquals(a, string.Intern(c)));     //True;
            Console.WriteLine(object.ReferenceEquals(a, d));                    //True;
            Console.WriteLine(object.ReferenceEquals(a, e));                    //False;
            Console.WriteLine(object.ReferenceEquals(a, f));                    //False;
            Console.WriteLine(object.ReferenceEquals(e, f));                    //False;
            Console.ReadKey();
        }
        #endregion

        #region 代理
        /// <summary>
        /// 静态代理
        /// </summary>
        static void StaticProxy()
        {
            Console.WriteLine($"静态代理{Environment.NewLine}-------------------------------------------");

            IHouse houseA = new HouseA();
            IHouse houseAProxy = new HouseProxy(houseA);
            houseAProxy.Buy();

            Console.WriteLine();

            IHouse houseB = new HouseB();
            IHouse houseBProxy = new HouseProxy(houseB);
            houseBProxy.Buy();

            Console.ReadKey();
        }

        /// <summary>
        /// 动态代理
        /// </summary>
        static void DynamicProxyByRemoting()
        {
            Console.WriteLine($"动态代理 Remoting{Environment.NewLine}-------------------------------------------");

            DynamicAction action = new DynamicAction();
            action.BeforeActionList.Add(new Action(() => Console.WriteLine("收取中介费")));
            action.BeforeActionList.Add(new Action(() => Console.WriteLine("办理各种过户手术")));
            action.AfterActionList.Add(new Action(() => Console.WriteLine("交易完成")));

            ProxyFactory<HouseA> factory = new ProxyFactory<HouseA>();
            HouseA houseA = factory.CreateProxy();
            houseA.Buy();
            Console.WriteLine("-----------------");

            houseA.Name = "房屋AAAAAAAAAAA";
            HouseA houseAA = factory.CreateProxy(houseA, action);
            houseAA.Buy();
            Console.WriteLine("-----------------");

            ProxyFactory<HouseB> factoryB = new ProxyFactory<HouseB>();
            HouseB houseB = factoryB.CreateProxy(action);
            houseB.Buy();
            Console.ReadKey();
        }

        /// <summary>
        /// 动态代理
        /// </summary>
        static void DynamicProxyByCastle()
        {
            Console.WriteLine($"动态代理 Castle{Environment.NewLine}-------------------------------------------");

            ProxyGenerator generator = new ProxyGenerator();
            HouseA houseA = generator.CreateClassProxy<HouseA>(new ClassInterceptor());
            houseA.Buy();
            Console.ReadKey();
        }
        #endregion

        #region 职责链
        /// <summary>
        /// 职责链模式
        /// </summary>
        static void ChainOfResponsibility()
        {
            Console.WriteLine($"职责链模式{Environment.NewLine}-------------------------------------------");

            ILoggerHandler infoLogger = new InfoLogger();
            ILoggerHandler debugLogger = new DebugLogger();
            ILoggerHandler warnLogger = new WarnLogger();
            ILoggerHandler errorLogger = new ErrorLogger();

            infoLogger.Successor = debugLogger;
            debugLogger.Successor = errorLogger;
            //errorLogger.Successor = warnLogger;

            infoLogger.Record("AAAAAAAAAAAA", LogLevelEmun.INFO);
            infoLogger.Record("BBBBBBBBBBBB", LogLevelEmun.DEBUG);
            infoLogger.Record("CCCCCCCCCCCC", LogLevelEmun.WARN);
            infoLogger.Record("DDDDDDDDDDDD", LogLevelEmun.ERROR);

            Console.ReadKey();
        }
        #endregion

        #region 命令
        /// <summary>
        /// 命令模式
        /// </summary>
        static void Command()
        {
            Console.WriteLine($"命令模式{Environment.NewLine}-------------------------------------------");

            Television tv = new Television();           //创建电视机对象（命令的接收者）

            ICommand tvOpen = new TvOpenCommand(tv);    //创建开机命令
            ICommand tvClose = new TvCloseCommand(tv);  //创建关机命令

            Button button = new Button(tvOpen);         //创建开机按钮（命令的调用者）
            button.Click();                             //执行命令

            button.Command = tvClose;                   //将按钮功能变更为关机
            button.Click();                             //执行命令

            Console.ReadKey();
        }

        /// <summary>
        /// 宏命令
        /// </summary>
        static void MacorCommand()
        {
            Console.WriteLine($"命令模式 -> 宏命令{Environment.NewLine}-------------------------------------------");

            Television tv = new Television();                       //电视对象（命令接收者）
            AirConditioner ac = new AirConditioner();               //空调对象（命令接收者）

            TvOpenCommand tvOpenCommand = new TvOpenCommand(tv);    //电视开机命令
            AcOpenCommand acOpenCommand = new AcOpenCommand(ac);    //空调开机命令
            MacorCommand macorCommand = new MacorCommand();         //宏命令
            macorCommand.Commands.Add(tvOpenCommand);               //设置宏命令
            macorCommand.Commands.Add(acOpenCommand);               //设置宏命令

            Button button = new Button(macorCommand);               //创建宏按钮
            button.Click();                                         //执行命令

            Console.ReadKey();
        }
        #endregion

        #region 解释器
        /// <summary>
        /// 解释器
        /// </summary>
        static void Interpreter()
        {
            Console.WriteLine($"解释器模式{Environment.NewLine}-------------------------------------------");

            OperationInterpreter interpreter = new OperationInterpreter();
            Console.WriteLine($"6/3+2*5-1+3 = {interpreter.Interpret("6/3+2*5-1+3")}");
            Console.ReadKey();
        }
        #endregion

        #region 迭代器
        /// <summary>
        /// 迭代器
        /// </summary>
        static void Iterator()
        {
            Console.WriteLine($"迭代器模式{Environment.NewLine}-------------------------------------------");

            Aggregate agg = new ConcreteAggregate();
            Iterator.Iterator iterator = agg.CreateIterator();

            while (iterator.Next())
            {
                Console.WriteLine(iterator.Current.ToString());
            }

            Console.ReadKey();
        }

        static void ForeachDemo()
        {
            Console.WriteLine($"foreach{Environment.NewLine}-------------------------------------------");

            ClassA classA = new ClassA();
            foreach (var item in classA)
            {
                Console.WriteLine($"-------{item.ToString()}");
            }

            Console.ReadKey();
        }
        #endregion

        #region 中介者
        /// <summary>
        /// 中介者
        /// </summary>
        static void Mediator()
        {
            Console.WriteLine($"中介者模式{Environment.NewLine}-------------------------------------------");

            Mediator.Mediator mediator = new Mediator.Mediator();   //创建中介者
            ColleagueA colleagueA = new ColleagueA(mediator);       //创建同事A
            ColleagueB colleagueB = new ColleagueB(mediator);       //创建同事B
            ColleagueC colleagueC = new ColleagueC();               //创建同事C
            ColleagueD colleagueD = new ColleagueD(mediator);       //创建同事D

            mediator.ColleagueAObj = colleagueA;                    //关联同事A
            mediator.ColleagueBObj = colleagueB;                    //关联同事B
            mediator.ColleagueCObj = colleagueC;                    //关联同事C

            colleagueA.OperationB();
            colleagueB.OperationA();
            colleagueD.Operation();
            Console.ReadKey();
        }
        #endregion

        #region 备忘录
        /// <summary>
        /// 备忘录
        /// </summary>
        static void Memento()
        {
            Console.WriteLine($"备忘录模式{Environment.NewLine}-------------------------------------------");

            Originator originator = new Originator();
            originator.State = "v1";

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "v2";
            Console.WriteLine($"[Originator.State]：{originator.State}");

            originator.Restore(caretaker.Memento);
            Console.WriteLine($"[Originator.State]：{originator.State}");

            Console.ReadKey();
        }

        /// <summary>
        /// 备忘录模式 + 命令模式
        /// </summary>
        static void MementoWithCommand()
        {
            Console.WriteLine($"备忘录模式 + 命令模式{Environment.NewLine}-------------------------------------------");

            Originator originator = new Originator();
            ChangeStateCommand command = new ChangeStateCommand(originator);
            command.Execute("v1");
            command.Execute("v2");

            Console.WriteLine($"[Originator.State]：{originator.State}");

            command.Undo();
            Console.WriteLine($"[Originator.State]：{originator.State}");

            Console.ReadKey();
        }
        #endregion

        #region 观察者
        /// <summary>
        /// 观察者
        /// </summary>
        static void OBServer()
        {
            Console.WriteLine($"观察者模式{Environment.NewLine}-------------------------------------------");

            Star star = new Star();
            IFans fandA = new FansA(star);
            IFans fansB = new FansB(star);

            star.CreateWeibo();
            Console.ReadKey();
        }
        #endregion

        #region 状态
        /// <summary>
        /// 状态
        /// </summary>
        static void State()
        {
            Console.WriteLine($"状态模式{Environment.NewLine}-------------------------------------------");

            try
            {
                //创建火车对象并将其状态初始化为“开门”状态
                Train train = new Train();
                train.State = TrainStateFactory.Instance.CreateOpenDoorState(train);

                train.CloseDoor();  //关门
                train.Run();        //开车
                train.Stop();       //停车
                train.OpenDoor();   //开门

                Console.ReadKey();

                train.Run();        //“开门”状态下开车
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
        #endregion

        #region 策略
        /// <summary>
        /// 策略
        /// </summary>
        static void Strategy()
        {
            Console.WriteLine($"策略模式{Environment.NewLine}-------------------------------------------");

            Console.WriteLine("精确搜索：");
            //SearchContext context = new SearchContext(new ExactSearchStrategy());
            SearchContext context = new SearchContext(new ExactAndCaseInsensitiveSearchStrategy());
            var dataList = context.Search("AB");
            dataList.ForEach(t => Console.WriteLine(t));
            Console.WriteLine("-------------------------");

            Console.WriteLine("模糊搜索:");
            //context = new SearchContext(new FuzzySearchStrategy());
            context = new SearchContext(new FuzzyAndCaseInsensitiveSearchStrategy());
            dataList = context.Search("AB");
            dataList.ForEach(t => Console.WriteLine(t));
            Console.ReadKey();
        }
        #endregion

        #region 模板方法
        /// <summary>
        /// 模板方法
        /// </summary>
        static void TemplateMethod()
        {
            Console.WriteLine($"模板方法模式{Environment.NewLine}-------------------------------------------");

            Console.WriteLine("开始制作：[意式浓缩咖啡]");
            CoffeTemplate coffe = new Espresso();
            coffe.MakeCoffe();
            Console.WriteLine($"制作完毕{Environment.NewLine}");

            Console.WriteLine("开始制作：[美式咖啡]");
            coffe = new Americano();
            coffe.MakeCoffe();
            Console.WriteLine($"制作完毕{Environment.NewLine}");

            Console.WriteLine("开始制作：[拿铁咖啡]");
            coffe = new Latte();
            coffe.MakeCoffe();
            Console.WriteLine($"制作完毕{Environment.NewLine}");
            Console.ReadKey();
        }
        #endregion

        #region 访问者
        /// <summary>
        /// 访问者
        /// </summary>
        static void Visitor()
        {
            Console.WriteLine($"访问者模式{Environment.NewLine}-------------------------------------------");

            //创建目录结构 Start
            IFile folderA = new Folder("FolderA");
            folderA.Add(new Txt("TxtA"));
            folderA.Add(new Png("PngA"));

            IFile folderB = new Folder("FolderB");
            folderB.Add(new Txt("TxtB"));
            folderB.Add(new Png("PngB"));

            IFile folderC = new Folder("FolderC");
            folderC.Add(new Txt("TxtC"));
            folderC.Add(new Png("PngC"));

            folderB.Add(folderC);
            IFile folder = new Folder("Folder");
            folder.Add(folderA);
            folder.Add(folderB);
            //创建目录结构 End

            FolderSumVisitor folderSumVisitor = new FolderSumVisitor();
            folder.Accept(folderSumVisitor);
            Console.WriteLine($"共有文件夹{folderSumVisitor.Sum}个");

            PngSumVisitor pngSumVisitor = new PngSumVisitor();
            folder.Accept(pngSumVisitor);
            Console.WriteLine($"共有png文件{pngSumVisitor.Sum}个");

            TxtNameVisitor txtNameVisitor = new TxtNameVisitor();
            folder.Accept(txtNameVisitor);
            Console.WriteLine($"{Environment.NewLine}所有的txt文件名如下：");
            txtNameVisitor.NameList.ForEach(t => Console.WriteLine(t));

            Console.ReadKey();
        }
        #endregion
    }
}
