using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Entidade
{
    /// <summary>
    /// Classe Heroes da Camada de Entidade
    /// </summary>
    public class Heroes
    {
       public long Id { get; set; }

        /// <summary>
        /// Hero Name
        /// </summary>
        public string HeroName { get; set; }

        /// <summary>
        /// Hero Description
        /// </summary>
        public string HeroDescription { get; set; }

        public string URL { get; set; }
    }
}
