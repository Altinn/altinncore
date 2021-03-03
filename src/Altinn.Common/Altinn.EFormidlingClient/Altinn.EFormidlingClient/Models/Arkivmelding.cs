﻿using System;
using System.Xml.Serialization;

namespace Altinn.EFormidlingClient.Models
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArkivmeldingMetadata"/> class.
    /// </summary>
    /// 
    [XmlRoot(ElementName = "arkivmelding")]
    public class Arkivmelding
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArkivmeldingMetadata"/> class.
        /// </summary>
        /// <param name="system">System</param>
        /// <param name="meldingId">MeldingId</param>
        /// <param name="tidspunkt">Tidspunkt</param>
        /// <param name="antallFiler">AntallFiler</param>
        /// <param name="basisregistrering">Basisregistrering</param>
        /// <param name="xmlns">Xmlns</param>
        /// <param name="xsi">Xsi</param>
        /// <param name="schemaLocation">SchemaLocation</param>
        /// <param name="text">Text</param>
        public Arkivmelding(string system, string meldingId, DateTime tidspunkt, int antallFiler, Basisregistrering basisregistrering, string xmlns, string xsi, string schemaLocation, string text)
        {
            System = system;
            MeldingId = meldingId;
            Tidspunkt = tidspunkt;
            AntallFiler = antallFiler;
            Basisregistrering = basisregistrering;
            Xmlns = xmlns;
            Xsi = xsi;
            SchemaLocation = schemaLocation;
            Text = text;
        }

        /// <summary>
        ///  Gets or sets the System
        /// </summary>
        [XmlElement(ElementName = "system")]
        public string System { get; set; }

        /// <summary>
        ///  Gets or sets the MeldingId
        /// </summary>
        [XmlElement(ElementName = "meldingId")]
        public string MeldingId { get; set; }

        /// <summary>
        ///  Gets or sets the Tidspunkt
        /// </summary>
        [XmlElement(ElementName = "tidspunkt")]
        public DateTime Tidspunkt { get; set; }

        /// <summary>
        ///  Gets or sets the AntallFiler
        /// </summary>
        [XmlElement(ElementName = "antallFiler")]
        public int AntallFiler { get; set; }

        /// <summary>
        ///  Gets or sets the Basisregistrering
        /// </summary>
        [XmlElement(ElementName = "basisregistrering")]
        public Basisregistrering Basisregistrering { get; set; }

        /// <summary>
        ///  Gets or sets the Xmlns
        /// </summary>
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        /// <summary>
        ///  Gets or sets the Xsi
        /// </summary>
        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        /// <summary>
        ///  Gets or sets the SchemaLocation
        /// </summary>
        [XmlAttribute(AttributeName = "schemaLocation")]
        public string SchemaLocation { get; set; }

        /// <summary>
        ///  Gets or sets the Text
        /// </summary>
        [XmlText]
        public string Text { get; set; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Dokumentobjekt"/> class.
    /// </summary>
    [XmlRoot(ElementName = "dokumentobjekt")]
    public class Dokumentobjekt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dokumentobjekt"/> class.
        /// </summary>
        /// <param name="versjonsnummer">Versjonsnummer</param>
        /// <param name="variantformat">Variantformat</param>
        /// <param name="opprettetDato">OpprettetDato</param>
        /// <param name="opprettetAv">OpprettetAv</param>
        /// <param name="referanseDokumentfil">ReferanseDokumentfil</param>
        public Dokumentobjekt(int versjonsnummer, string variantformat, DateTime opprettetDato, string opprettetAv, string referanseDokumentfil)
        {
            Versjonsnummer = versjonsnummer;
            Variantformat = variantformat;
            OpprettetDato = opprettetDato;
            OpprettetAv = opprettetAv;
            ReferanseDokumentfil = referanseDokumentfil;
        }

        /// <summary>
        ///  Gets or sets the Versjonsnummer
        /// </summary>
        [XmlElement(ElementName = "versjonsnummer")]
        public int Versjonsnummer { get; set; }

        /// <summary>
        ///  Gets or sets the Variantformat
        /// </summary>
        [XmlElement(ElementName = "variantformat")]
        public string Variantformat { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetDato
        /// </summary>
        [XmlElement(ElementName = "opprettetDato")]
        public DateTime OpprettetDato { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetAv
        /// </summary>
        [XmlElement(ElementName = "opprettetAv")]
        public string OpprettetAv { get; set; }

        /// <summary>
        ///  Gets or sets the ReferanseDokumentfil
        /// </summary>
        [XmlElement(ElementName = "referanseDokumentfil")]
        public string ReferanseDokumentfil { get; set; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Dokumentbeskrivelse"/> class.
    /// </summary>
    [XmlRoot(ElementName = "dokumentbeskrivelse")]
    public class Dokumentbeskrivelse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dokumentbeskrivelse"/> class.
        /// </summary>
        /// <param name="systemID">systemID</param>
        /// <param name="dokumenttype">dokumenttype</param>
        /// <param name="dokumentstatus">dokumentstatus</param>
        /// <param name="tittel">tittel</param>
        /// <param name="opprettetDato">opprettetDato</param>
        /// <param name="opprettetAv">opprettetAv</param>
        /// <param name="tilknyttetRegistreringSom">tilknyttetRegistreringSom</param>
        /// <param name="dokumentnummer">dokumentnummer</param>
        /// <param name="tilknyttetDato">tilknyttetDato</param>
        /// <param name="tilknyttetAv">tilknyttetAv</param>
        /// <param name="dokumentobjekt">dokumentobjekt</param>
        public Dokumentbeskrivelse(string systemID, string dokumenttype, string dokumentstatus, string tittel, DateTime opprettetDato, string opprettetAv, string tilknyttetRegistreringSom, int dokumentnummer, DateTime tilknyttetDato, string tilknyttetAv, Dokumentobjekt dokumentobjekt)
        {
            SystemID = systemID;
            Dokumenttype = dokumenttype;
            Dokumentstatus = dokumentstatus;
            Tittel = tittel;
            OpprettetDato = opprettetDato;
            OpprettetAv = opprettetAv;
            TilknyttetRegistreringSom = tilknyttetRegistreringSom;
            Dokumentnummer = dokumentnummer;
            TilknyttetDato = tilknyttetDato;
            TilknyttetAv = tilknyttetAv;
            Dokumentobjekt = dokumentobjekt;
        }

        /// <summary>
        ///  Gets or sets the SystemID
        /// </summary>
        [XmlElement(ElementName = "systemID")]
        public string SystemID { get; set; }

        /// <summary>
        ///  Gets or sets the Dokumenttype
        /// </summary>
        [XmlElement(ElementName = "dokumenttype")]
        public string Dokumenttype { get; set; }

        /// <summary>
        ///  Gets or sets the Dokumentstatus
        /// </summary>
        [XmlElement(ElementName = "dokumentstatus")]
        public string Dokumentstatus { get; set; }

        /// <summary>
        ///  Gets or sets the Tittel
        /// </summary>
        [XmlElement(ElementName = "tittel")]
        public string Tittel { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetDato
        /// </summary>
        [XmlElement(ElementName = "opprettetDato")]
        public DateTime OpprettetDato { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetAv
        /// </summary>
        [XmlElement(ElementName = "opprettetAv")]
        public string OpprettetAv { get; set; }

        /// <summary>
        ///  Gets or sets the TilknyttetRegistreringSom
        /// </summary>
        [XmlElement(ElementName = "tilknyttetRegistreringSom")]
        public string TilknyttetRegistreringSom { get; set; }

        /// <summary>
        ///  Gets or sets the Dokumentnummer
        /// </summary>
        [XmlElement(ElementName = "dokumentnummer")]
        public int Dokumentnummer { get; set; }

        /// <summary>
        ///  Gets or sets the TilknyttetDato
        /// </summary>
        [XmlElement(ElementName = "tilknyttetDato")]
        public DateTime TilknyttetDato { get; set; }

        /// <summary>
        ///  Gets or sets the TilknyttetAv
        /// </summary>
        [XmlElement(ElementName = "tilknyttetAv")]
        public string TilknyttetAv { get; set; }

        /// <summary>
        ///  Gets or sets the Dokumentobjekt
        /// </summary>
        [XmlElement(ElementName = "dokumentobjekt")]
        public Dokumentobjekt Dokumentobjekt { get; set; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Korrespondansepart"/> class.
    /// </summary>
    [XmlRoot(ElementName = "korrespondansepart")]
    public class Korrespondansepart
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Korrespondansepart"/> class.
        /// </summary>
        /// <param name="korrespondanseparttype">Korrespondanseparttype</param>
        /// <param name="korrespondansepartNavn">KorrespondansepartNavn</param>
        public Korrespondansepart(string korrespondanseparttype, string korrespondansepartNavn)
        {
            Korrespondanseparttype = korrespondanseparttype;
            KorrespondansepartNavn = korrespondansepartNavn;
        }

        /// <summary>
        ///  Gets or sets the Korrespondanseparttype
        /// </summary>
        [XmlElement(ElementName = "korrespondanseparttype")]
        public string Korrespondanseparttype { get; set; }

        /// <summary>
        ///  Gets or sets the KorrespondansepartNavn
        /// </summary>
        [XmlElement(ElementName = "korrespondansepartNavn")]
        public string KorrespondansepartNavn { get; set; }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Basisregistrering"/> class.
    /// </summary>
    [XmlRoot(ElementName = "basisregistrering")]
    public class Basisregistrering
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Basisregistrering"/> class.
        /// </summary>
        /// <param name="systemID">SystemID</param>
        /// <param name="opprettetDato">OpprettetDato</param>
        /// <param name="opprettetAv">OpprettetAv</param>
        /// <param name="arkivertDato">ArkivertDato</param>
        /// <param name="arkivertAv">ArkivertAv</param>
        /// <param name="referanseForelderMappe">ReferanseForelderMappe</param>
        /// <param name="dokumentbeskrivelse">Dokumentbeskrivelse</param>
        /// <param name="tittel">Tittel</param>
        /// <param name="offentligTittel">OffentligTittel</param>
        /// <param name="journalposttype">Journalposttype</param>
        /// <param name="journalstatus">Journalstatus</param>
        /// <param name="journaldato">Journaldato</param>
        /// <param name="korrespondansepart">Korrespondansepart</param>
        /// <param name="type">Type</param>
        /// <param name="text">Text</param>
        public Basisregistrering(string systemID, DateTime opprettetDato, string opprettetAv, DateTime arkivertDato, string arkivertAv, string referanseForelderMappe, Dokumentbeskrivelse dokumentbeskrivelse, string tittel, string offentligTittel, string journalposttype, string journalstatus, DateTime journaldato, Korrespondansepart korrespondansepart, string type, string text)
        {
            SystemID = systemID;
            OpprettetDato = opprettetDato;
            OpprettetAv = opprettetAv;
            ArkivertDato = arkivertDato;
            ArkivertAv = arkivertAv;
            ReferanseForelderMappe = referanseForelderMappe;
            Dokumentbeskrivelse = dokumentbeskrivelse;
            Tittel = tittel;
            OffentligTittel = offentligTittel;
            Journalposttype = journalposttype;
            Journalstatus = journalstatus;
            Journaldato = journaldato;
            Korrespondansepart = korrespondansepart;
            Type = type;
            Text = text;
        }

        /// <summary>
        ///  Gets or sets the SystemID
        /// </summary>
        [XmlElement(ElementName = "systemID")]
        public string SystemID { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetDato
        /// </summary>
        [XmlElement(ElementName = "opprettetDato")]
        public DateTime OpprettetDato { get; set; }

        /// <summary>
        ///  Gets or sets the OpprettetAv
        /// </summary>
        [XmlElement(ElementName = "opprettetAv")]
        public string OpprettetAv { get; set; }

        /// <summary>
        ///  Gets or sets the ArkivertDato
        /// </summary>
        [XmlElement(ElementName = "arkivertDato")]
        public DateTime ArkivertDato { get; set; }

        /// <summary>
        ///  Gets or sets the ArkivertAv
        /// </summary>
        [XmlElement(ElementName = "arkivertAv")]
        public string ArkivertAv { get; set; }

        /// <summary>
        ///  Gets or sets the ReferanseForelderMappe
        /// </summary>
        [XmlElement(ElementName = "referanseForelderMappe")]
        public string ReferanseForelderMappe { get; set; }

        /// <summary>
        ///  Gets or sets the Dokumentbeskrivelse
        /// </summary>
        [XmlElement(ElementName = "dokumentbeskrivelse")]
        public Dokumentbeskrivelse Dokumentbeskrivelse { get; set; }

        /// <summary>
        ///  Gets or sets the Tittel
        /// </summary>
        [XmlElement(ElementName = "tittel")]
        public string Tittel { get; set; }

        /// <summary>
        ///  Gets or sets the OffentligTittel
        /// </summary>
        [XmlElement(ElementName = "offentligTittel")]
        public string OffentligTittel { get; set; }

        /// <summary>
        ///  Gets or sets the Journalposttype
        /// </summary>
        [XmlElement(ElementName = "journalposttype")]
        public string Journalposttype { get; set; }

        /// <summary>
        ///  Gets or sets the Journalstatus
        /// </summary>
        [XmlElement(ElementName = "journalstatus")]
        public string Journalstatus { get; set; }

        /// <summary>
        ///  Gets or sets the Journaldato
        /// </summary>
        [XmlElement(ElementName = "journaldato")]
        public DateTime Journaldato { get; set; }

        /// <summary>
        ///  Gets or sets the Korrespondansepart
        /// </summary>
        [XmlElement(ElementName = "korrespondansepart")]
        public Korrespondansepart Korrespondansepart { get; set; }

        /// <summary>
        ///  Gets or sets the Type
        /// </summary>
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///  Gets or sets the Text
        /// </summary>
        [XmlText]
        public string Text { get; set; }
    }
}