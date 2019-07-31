using System;

namespace DesignPatterns.DesignPatterns.Observer
{
    class Speaker
    {
        Forum forum;

        public Speaker(string name, Forum forum)
        {
            this.forum = forum;
            Name = name;
            forum.SpeakerEnters += EnterSpeaker;

            forum.SpeakerExits += ExitSpeaker;

            forum.EnterNewSpeaker(this, Name);
        }

        private void EnterSpeaker(object sender, string senderName)
        {
            if (sender != this)
            {
                Console.WriteLine($"Hi {Name}, {senderName} has entered the Forum.");
            }
        }

        private void ExitSpeaker(object sender, string senderName)
        {
            if (sender != this)
            {
                Console.WriteLine($"{senderName} has exited the Forum.");
            }
        }

        internal string Name { get; }

        public void ExitTheForum()
        {
            Console.WriteLine($"You are leaving the forum so early {Name}.");
            forum.SpeakerEnters -= EnterSpeaker;
            forum.SpeakerExits -= ExitSpeaker;
            forum.ExitSpeaker(this, Name);
        }
    }
}
