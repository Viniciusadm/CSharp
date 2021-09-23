using System;

namespace ConjuntoLog {
    public class Log {
        public Log(string usuário, DateTime momento) {
            this.Usuário = usuário;
            this.Momento = momento;
        }

        public string Usuário { get; set; }
        public DateTime Momento { get; set; }

        public override int GetHashCode() {
            return Usuário.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Log))
                return false;
            Log outro = obj as Log;
            return this.Usuário == outro.Usuário;
        }
    }
}