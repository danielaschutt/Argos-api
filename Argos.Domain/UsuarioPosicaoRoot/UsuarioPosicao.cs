using Argos.Domain.BaseRoot;
using Argos.Domain.UsuarioRoot;
using System;


namespace Argos.Domain.UsuarioPosicaoRoot
{
    public class UsuarioPosicao : Entity
    {
        public Usuario Usuario { get; set; }
        public long UsuarioId { get; set; }
        public DateTime CriadoEm { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }

        public UsuarioPosicao(DateTime criadoEm, double latitude, double longitude, long usuarioId)
        {
            this.CriadoEm = criadoEm;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.UsuarioId = usuarioId;
        }

    }
}