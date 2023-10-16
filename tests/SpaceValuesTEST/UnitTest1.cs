using SpaceValuesTEST.Clases;

namespace SpaceValuesTEST
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestDamage()
        {
            Character character = new Character();
            character.Health = 10;
            character.MaxHealth = 10;


            character.TakeDamage(10);
            if(character.Health != 0)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void TestSpeed()
        {
            float s1 = 3.5f;
            float s2 = 1.2f;
            Character character = new Character();
            character.Health = 10;
            character.MaxHealth = 10;
            character.Speed = s1;
            character.Accelerate(s2);

            if(character.Speed != s1 + s2)
            { 
                Assert.Fail();
            }
        }
        [Test]
        public void TestDeath()
        {
            Character character = new Character();
            character.Health = 10;
            character.MaxHealth = 10;
            character.Speed = 3.5f;

            character.Dead();
            if(character.Speed != 0)
            {
                Assert.Fail();
            }
        }
    }
}