using System;

namespace MusoeunEngine
{
    interface MusoeunBehavior
    {
        public void Awake();
        public void Start();
        public void Update();
        public void Render();
    }
}
