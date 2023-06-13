using System;

namespace lab_3.Mob
{
    class Monster
    {
        public int _maxHP = 100;
        public int _currentHP = 100;

        public int _monsterDamage = 0;

        public int _Weight;
        public string? _monsterAction;

        public Monster()
        {
            _monsterAction = "";
            _Weight = 50; // Toooooo fat monster)
        }

        public bool CheckMonsterHP()
        {
            if (_currentHP <= 0)
            {
                _monsterAction = "Монстр умер!";
                return true;
            }

            return false;
        }

        public void Attack()
        {
            _monsterAction = "Монстр атакует";
            _monsterDamage = 5;
        }

        public void Update()
        {
            _monsterDamage = 0;
        }

        public void DealDamage(int damage)
        {
            if (CheckMonsterHP())
                return;

            _monsterAction = "Вы атакуете монстра";
            _currentHP -= damage;
            if(_currentHP < 0)
            {
                _currentHP = 0;
            }
        }

        public void CutMeat()
        {
            if (CheckMonsterHP())
                return;

            _monsterAction = "Вы отрезали кусок мяса";
            var rnd = new Random();

            _currentHP -= rnd.Next(0, 10);
            if (_currentHP < 0)
            {
                _currentHP = 0;
            }
        }

        public void Heal()
        {
            if (CheckMonsterHP())
                return;

            var rnd = new Random();
            int toHP = rnd.Next(0, 99);

            _monsterAction = $"Монстр восстановил себе {toHP} ед.здоровья";
            _currentHP += toHP;
            if (_currentHP > _maxHP)
            {
                _currentHP = _maxHP;
            }
        }

    }
}
