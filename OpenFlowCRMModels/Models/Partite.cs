﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace OpenFlowCRMModels.Models
{
    [Serializable]
    public partial class Partite
    {
        public long PartiteId { get; set; }
        public string Descrizione { get; set; }
        public int PezziAlCarico { get; set; }
        public int Ncarichi { get; set; }
        public DateTime DataConsegna { get; set; }
        public long Modello { get; set; }
        public long? Ordine { get; set; }
        public STATO_PARTITA Stato { get; set; }

        public virtual CatalogoModelli ModelloNavigation { get; set; }
        public virtual Ordini OrdineNavigation { get; set; }
    }
}