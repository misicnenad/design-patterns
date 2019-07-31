using System;

namespace DesignPatterns.DesignPatterns.Observer
{
    class Forum
    {
        internal event EventHandler<string> SpeakerEnters,SpeakerExits;

        internal void EnterNewSpeaker(object newSpeaker, string newSpeakerName)
        {
            if (SpeakerEnters?.GetInvocationList().Length == 1)
            {
                Console.WriteLine($"{newSpeakerName} enters the Forum as the first speaker.");
            }
            SpeakerEnters?.Invoke(newSpeaker, newSpeakerName);
        }

        internal void ExitSpeaker(object speaker, string newSpeakerName)
        {
            SpeakerExits?.Invoke(speaker, newSpeakerName);
        }
    }
}
