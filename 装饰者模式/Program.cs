using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式
{
    public abstract class AbstractEquipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public abstract void Attack();
    }

    public class Gun : AbstractEquipment
    {
        public override void Attack()
        {
            Console.WriteLine("用枪攻击");
        }
    }

    class Sword : AbstractEquipment
    {
        public override void Attack()
        {
            Console.WriteLine("用剑攻击");
        }
    }


    public class BaseEquipmentDecorator : AbstractEquipment
    {
        private AbstractEquipment _equipment = null;
        public BaseEquipmentDecorator(AbstractEquipment equipment)
        {
            _equipment = equipment;
        }
        public override void Attack()
        {
            _equipment.Attack();
        }
    }

    public class EquipmentStrengthenDecorator : BaseEquipmentDecorator
    {
        //调用直接父类的指定构造函数
        public EquipmentStrengthenDecorator(AbstractEquipment equipment)
            :base(equipment)
        {

        }
        public override void Attack()
        {
            base.Attack();
            Strengthen();
        }
        public void Strengthen()
        {
            Console.WriteLine("武器被强化");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AbstractEquipment gun = new Gun();
            gun = new EquipmentStrengthenDecorator(gun);
            gun.Attack();
            Console.ReadKey();
        }
    }
}
