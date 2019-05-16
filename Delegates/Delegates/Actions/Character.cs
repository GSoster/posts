using System;

namespace Delegates.Actions
{
    public class Character
    {
        public event EventHandler<ActionEvent> DamageTakenEventHandler;

        public string Name { get; set; }
        public short Attack { get; set; }
        public short Defense { get; set; }

        public void Combat(Character enemy)
        {
            if (enemy.Attack > this.Defense)
                OnDamageTaken(enemy);
        }

        protected virtual void OnDamageTaken(Character enemy)
        {
            if (this.DamageTakenEventHandler != null)
                DamageTakenEventHandler(this, new ActionEvent() { Responsible = enemy, ActionName = "Dealt Damage" });
        }
    }
}