using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceValuesTEST.Clases
{
    internal class Character
    {
        private byte health;
        private byte maxHealth;
        private float speed;



        public byte Health { get => health; set => health = value; }
        public byte MaxHealth { get => maxHealth; set => maxHealth = value; }
        public float Speed { get => speed; set => speed = value; }



        internal void Accelerate(float acceleration)
        {
            speed += acceleration;
        }
        internal void TakeDamage(byte amount)
        {
            Health -= amount;
        }
        internal void CheckDeath()
        {
            if (Health <= 0)
            {
                Dead();
            }
        }
        internal void Dead()
        {
            speed = 0;
            //Destroy
        }
    }
}
