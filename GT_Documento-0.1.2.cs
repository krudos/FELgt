///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 18.0.11                                   //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = True
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = krudos.FELgt.Documento012
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd
//    C:\dev\xsd\GT_Documento-0.1.2.xsd
//    C:\dev\xsd\GT_Documento-0.2.1.xsd


namespace krudos.FELgt.Documento012
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("18.0.11.10216", "Trial for Non-Commercial Use Expiry [2020-09-02]", "3YFDDJ84HCUDYX5Y", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

    #region Global Base Class
    /// <summary>All generated Lx classes derive from this base class.</summary>
    /// <remarks>Notes to implementers. The class is declared partial, so additional members and properties can be added that will be available in all Lx generated classes.</remarks>
    public partial class LxBase
    {
        #region Unprocessed Node Handlers
        /// <summary>Any child elements that do not belong in this element are added to the UnprocessedElements collection.</summary>
        [LxElementUnprocessed()]
        public List<XElement> UnprocessedElements { get; } = new List<XElement>();

        /// <summary>Any attributes that do not belong in this element are added to the UnprocessedAttributes collection.</summary>
        [LxAttributeUnprocessed()]
        public List<XAttribute> UnprocessedAttributes { get; } = new List<XAttribute>();

        #endregion

    }

    #endregion

}

namespace krudos.FELgt.Documento012.Dte
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type tipoCodigoPais@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <remarks>Código de País ISO 3166-1</remarks>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/simpleType:tipoCodigoPais</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>819:2-1071:18</XsdLocation>
    public enum TipoCodigoPaisEnum
    {
        /// <summary>Represents the value 'AD' in the XML</summary>
        [LxEnumValue("AD")]
        AD,
        /// <summary>Represents the value 'AE' in the XML</summary>
        [LxEnumValue("AE")]
        AE,
        /// <summary>Represents the value 'AF' in the XML</summary>
        [LxEnumValue("AF")]
        AF,
        /// <summary>Represents the value 'AG' in the XML</summary>
        [LxEnumValue("AG")]
        AG,
        /// <summary>Represents the value 'AI' in the XML</summary>
        [LxEnumValue("AI")]
        AI,
        /// <summary>Represents the value 'AL' in the XML</summary>
        [LxEnumValue("AL")]
        AL,
        /// <summary>Represents the value 'AM' in the XML</summary>
        [LxEnumValue("AM")]
        AM,
        /// <summary>Represents the value 'AN' in the XML</summary>
        [LxEnumValue("AN")]
        AN,
        /// <summary>Represents the value 'AO' in the XML</summary>
        [LxEnumValue("AO")]
        AO,
        /// <summary>Represents the value 'AQ' in the XML</summary>
        [LxEnumValue("AQ")]
        AQ,
        /// <summary>Represents the value 'AR' in the XML</summary>
        [LxEnumValue("AR")]
        AR,
        /// <summary>Represents the value 'AS' in the XML</summary>
        [LxEnumValue("AS")]
        AS_,
        /// <summary>Represents the value 'AT' in the XML</summary>
        [LxEnumValue("AT")]
        AT,
        /// <summary>Represents the value 'AU' in the XML</summary>
        [LxEnumValue("AU")]
        AU,
        /// <summary>Represents the value 'AW' in the XML</summary>
        [LxEnumValue("AW")]
        AW,
        /// <summary>Represents the value 'AX' in the XML</summary>
        [LxEnumValue("AX")]
        AX,
        /// <summary>Represents the value 'AZ' in the XML</summary>
        [LxEnumValue("AZ")]
        AZ,
        /// <summary>Represents the value 'BA' in the XML</summary>
        [LxEnumValue("BA")]
        BA,
        /// <summary>Represents the value 'BB' in the XML</summary>
        [LxEnumValue("BB")]
        BB,
        /// <summary>Represents the value 'BD' in the XML</summary>
        [LxEnumValue("BD")]
        BD,
        /// <summary>Represents the value 'BE' in the XML</summary>
        [LxEnumValue("BE")]
        BE,
        /// <summary>Represents the value 'BF' in the XML</summary>
        [LxEnumValue("BF")]
        BF,
        /// <summary>Represents the value 'BG' in the XML</summary>
        [LxEnumValue("BG")]
        BG,
        /// <summary>Represents the value 'BH' in the XML</summary>
        [LxEnumValue("BH")]
        BH,
        /// <summary>Represents the value 'BI' in the XML</summary>
        [LxEnumValue("BI")]
        BI,
        /// <summary>Represents the value 'BJ' in the XML</summary>
        [LxEnumValue("BJ")]
        BJ,
        /// <summary>Represents the value 'BL' in the XML</summary>
        [LxEnumValue("BL")]
        BL,
        /// <summary>Represents the value 'BM' in the XML</summary>
        [LxEnumValue("BM")]
        BM,
        /// <summary>Represents the value 'BN' in the XML</summary>
        [LxEnumValue("BN")]
        BN,
        /// <summary>Represents the value 'BO' in the XML</summary>
        [LxEnumValue("BO")]
        BO,
        /// <summary>Represents the value 'BR' in the XML</summary>
        [LxEnumValue("BR")]
        BR,
        /// <summary>Represents the value 'BS' in the XML</summary>
        [LxEnumValue("BS")]
        BS,
        /// <summary>Represents the value 'BT' in the XML</summary>
        [LxEnumValue("BT")]
        BT,
        /// <summary>Represents the value 'BV' in the XML</summary>
        [LxEnumValue("BV")]
        BV,
        /// <summary>Represents the value 'BW' in the XML</summary>
        [LxEnumValue("BW")]
        BW,
        /// <summary>Represents the value 'BY' in the XML</summary>
        [LxEnumValue("BY")]
        BY,
        /// <summary>Represents the value 'BZ' in the XML</summary>
        [LxEnumValue("BZ")]
        BZ,
        /// <summary>Represents the value 'CA' in the XML</summary>
        [LxEnumValue("CA")]
        CA,
        /// <summary>Represents the value 'CC' in the XML</summary>
        [LxEnumValue("CC")]
        CC,
        /// <summary>Represents the value 'CD' in the XML</summary>
        [LxEnumValue("CD")]
        CD,
        /// <summary>Represents the value 'CF' in the XML</summary>
        [LxEnumValue("CF")]
        CF,
        /// <summary>Represents the value 'CG' in the XML</summary>
        [LxEnumValue("CG")]
        CG,
        /// <summary>Represents the value 'CH' in the XML</summary>
        [LxEnumValue("CH")]
        CH,
        /// <summary>Represents the value 'CI' in the XML</summary>
        [LxEnumValue("CI")]
        CI,
        /// <summary>Represents the value 'CK' in the XML</summary>
        [LxEnumValue("CK")]
        CK,
        /// <summary>Represents the value 'CL' in the XML</summary>
        [LxEnumValue("CL")]
        CL,
        /// <summary>Represents the value 'CM' in the XML</summary>
        [LxEnumValue("CM")]
        CM,
        /// <summary>Represents the value 'CN' in the XML</summary>
        [LxEnumValue("CN")]
        CN,
        /// <summary>Represents the value 'CO' in the XML</summary>
        [LxEnumValue("CO")]
        CO,
        /// <summary>Represents the value 'CR' in the XML</summary>
        [LxEnumValue("CR")]
        CR,
        /// <summary>Represents the value 'CU' in the XML</summary>
        [LxEnumValue("CU")]
        CU,
        /// <summary>Represents the value 'CV' in the XML</summary>
        [LxEnumValue("CV")]
        CV,
        /// <summary>Represents the value 'CX' in the XML</summary>
        [LxEnumValue("CX")]
        CX,
        /// <summary>Represents the value 'CY' in the XML</summary>
        [LxEnumValue("CY")]
        CY,
        /// <summary>Represents the value 'CZ' in the XML</summary>
        [LxEnumValue("CZ")]
        CZ,
        /// <summary>Represents the value 'DE' in the XML</summary>
        [LxEnumValue("DE")]
        DE,
        /// <summary>Represents the value 'DJ' in the XML</summary>
        [LxEnumValue("DJ")]
        DJ,
        /// <summary>Represents the value 'DK' in the XML</summary>
        [LxEnumValue("DK")]
        DK,
        /// <summary>Represents the value 'DM' in the XML</summary>
        [LxEnumValue("DM")]
        DM,
        /// <summary>Represents the value 'DO' in the XML</summary>
        [LxEnumValue("DO")]
        DO_,
        /// <summary>Represents the value 'DZ' in the XML</summary>
        [LxEnumValue("DZ")]
        DZ,
        /// <summary>Represents the value 'EC' in the XML</summary>
        [LxEnumValue("EC")]
        EC,
        /// <summary>Represents the value 'EE' in the XML</summary>
        [LxEnumValue("EE")]
        EE,
        /// <summary>Represents the value 'EG' in the XML</summary>
        [LxEnumValue("EG")]
        EG,
        /// <summary>Represents the value 'EH' in the XML</summary>
        [LxEnumValue("EH")]
        EH,
        /// <summary>Represents the value 'ER' in the XML</summary>
        [LxEnumValue("ER")]
        ER,
        /// <summary>Represents the value 'ES' in the XML</summary>
        [LxEnumValue("ES")]
        ES,
        /// <summary>Represents the value 'ET' in the XML</summary>
        [LxEnumValue("ET")]
        ET,
        /// <summary>Represents the value 'FI' in the XML</summary>
        [LxEnumValue("FI")]
        FI,
        /// <summary>Represents the value 'FJ' in the XML</summary>
        [LxEnumValue("FJ")]
        FJ,
        /// <summary>Represents the value 'FK' in the XML</summary>
        [LxEnumValue("FK")]
        FK,
        /// <summary>Represents the value 'FM' in the XML</summary>
        [LxEnumValue("FM")]
        FM,
        /// <summary>Represents the value 'FO' in the XML</summary>
        [LxEnumValue("FO")]
        FO,
        /// <summary>Represents the value 'FR' in the XML</summary>
        [LxEnumValue("FR")]
        FR,
        /// <summary>Represents the value 'GA' in the XML</summary>
        [LxEnumValue("GA")]
        GA,
        /// <summary>Represents the value 'GB' in the XML</summary>
        [LxEnumValue("GB")]
        GB,
        /// <summary>Represents the value 'GD' in the XML</summary>
        [LxEnumValue("GD")]
        GD,
        /// <summary>Represents the value 'GE' in the XML</summary>
        [LxEnumValue("GE")]
        GE,
        /// <summary>Represents the value 'GF' in the XML</summary>
        [LxEnumValue("GF")]
        GF,
        /// <summary>Represents the value 'GG' in the XML</summary>
        [LxEnumValue("GG")]
        GG,
        /// <summary>Represents the value 'GH' in the XML</summary>
        [LxEnumValue("GH")]
        GH,
        /// <summary>Represents the value 'GI' in the XML</summary>
        [LxEnumValue("GI")]
        GI,
        /// <summary>Represents the value 'GL' in the XML</summary>
        [LxEnumValue("GL")]
        GL,
        /// <summary>Represents the value 'GM' in the XML</summary>
        [LxEnumValue("GM")]
        GM,
        /// <summary>Represents the value 'GN' in the XML</summary>
        [LxEnumValue("GN")]
        GN,
        /// <summary>Represents the value 'GP' in the XML</summary>
        [LxEnumValue("GP")]
        GP,
        /// <summary>Represents the value 'GQ' in the XML</summary>
        [LxEnumValue("GQ")]
        GQ,
        /// <summary>Represents the value 'GR' in the XML</summary>
        [LxEnumValue("GR")]
        GR,
        /// <summary>Represents the value 'GS' in the XML</summary>
        [LxEnumValue("GS")]
        GS,
        /// <summary>Represents the value 'GT' in the XML</summary>
        [LxEnumValue("GT")]
        GT,
        /// <summary>Represents the value 'GU' in the XML</summary>
        [LxEnumValue("GU")]
        GU,
        /// <summary>Represents the value 'GW' in the XML</summary>
        [LxEnumValue("GW")]
        GW,
        /// <summary>Represents the value 'GY' in the XML</summary>
        [LxEnumValue("GY")]
        GY,
        /// <summary>Represents the value 'HK' in the XML</summary>
        [LxEnumValue("HK")]
        HK,
        /// <summary>Represents the value 'HM' in the XML</summary>
        [LxEnumValue("HM")]
        HM,
        /// <summary>Represents the value 'HN' in the XML</summary>
        [LxEnumValue("HN")]
        HN,
        /// <summary>Represents the value 'HR' in the XML</summary>
        [LxEnumValue("HR")]
        HR,
        /// <summary>Represents the value 'HT' in the XML</summary>
        [LxEnumValue("HT")]
        HT,
        /// <summary>Represents the value 'HU' in the XML</summary>
        [LxEnumValue("HU")]
        HU,
        /// <summary>Represents the value 'ID' in the XML</summary>
        [LxEnumValue("ID")]
        ID,
        /// <summary>Represents the value 'IE' in the XML</summary>
        [LxEnumValue("IE")]
        IE,
        /// <summary>Represents the value 'IL' in the XML</summary>
        [LxEnumValue("IL")]
        IL,
        /// <summary>Represents the value 'IM' in the XML</summary>
        [LxEnumValue("IM")]
        IM,
        /// <summary>Represents the value 'IN' in the XML</summary>
        [LxEnumValue("IN")]
        IN_,
        /// <summary>Represents the value 'IO' in the XML</summary>
        [LxEnumValue("IO")]
        IO,
        /// <summary>Represents the value 'IQ' in the XML</summary>
        [LxEnumValue("IQ")]
        IQ,
        /// <summary>Represents the value 'IR' in the XML</summary>
        [LxEnumValue("IR")]
        IR,
        /// <summary>Represents the value 'IS' in the XML</summary>
        [LxEnumValue("IS")]
        IS_,
        /// <summary>Represents the value 'IT' in the XML</summary>
        [LxEnumValue("IT")]
        IT,
        /// <summary>Represents the value 'JE' in the XML</summary>
        [LxEnumValue("JE")]
        JE,
        /// <summary>Represents the value 'JM' in the XML</summary>
        [LxEnumValue("JM")]
        JM,
        /// <summary>Represents the value 'JO' in the XML</summary>
        [LxEnumValue("JO")]
        JO,
        /// <summary>Represents the value 'JP' in the XML</summary>
        [LxEnumValue("JP")]
        JP,
        /// <summary>Represents the value 'KE' in the XML</summary>
        [LxEnumValue("KE")]
        KE,
        /// <summary>Represents the value 'KG' in the XML</summary>
        [LxEnumValue("KG")]
        KG,
        /// <summary>Represents the value 'KH' in the XML</summary>
        [LxEnumValue("KH")]
        KH,
        /// <summary>Represents the value 'KI' in the XML</summary>
        [LxEnumValue("KI")]
        KI,
        /// <summary>Represents the value 'KM' in the XML</summary>
        [LxEnumValue("KM")]
        KM,
        /// <summary>Represents the value 'KN' in the XML</summary>
        [LxEnumValue("KN")]
        KN,
        /// <summary>Represents the value 'KP' in the XML</summary>
        [LxEnumValue("KP")]
        KP,
        /// <summary>Represents the value 'KR' in the XML</summary>
        [LxEnumValue("KR")]
        KR,
        /// <summary>Represents the value 'KW' in the XML</summary>
        [LxEnumValue("KW")]
        KW,
        /// <summary>Represents the value 'KY' in the XML</summary>
        [LxEnumValue("KY")]
        KY,
        /// <summary>Represents the value 'KZ' in the XML</summary>
        [LxEnumValue("KZ")]
        KZ,
        /// <summary>Represents the value 'LA' in the XML</summary>
        [LxEnumValue("LA")]
        LA,
        /// <summary>Represents the value 'LB' in the XML</summary>
        [LxEnumValue("LB")]
        LB,
        /// <summary>Represents the value 'LC' in the XML</summary>
        [LxEnumValue("LC")]
        LC,
        /// <summary>Represents the value 'LI' in the XML</summary>
        [LxEnumValue("LI")]
        LI,
        /// <summary>Represents the value 'LK' in the XML</summary>
        [LxEnumValue("LK")]
        LK,
        /// <summary>Represents the value 'LR' in the XML</summary>
        [LxEnumValue("LR")]
        LR,
        /// <summary>Represents the value 'LS' in the XML</summary>
        [LxEnumValue("LS")]
        LS,
        /// <summary>Represents the value 'LT' in the XML</summary>
        [LxEnumValue("LT")]
        LT,
        /// <summary>Represents the value 'LU' in the XML</summary>
        [LxEnumValue("LU")]
        LU,
        /// <summary>Represents the value 'LV' in the XML</summary>
        [LxEnumValue("LV")]
        LV,
        /// <summary>Represents the value 'LY' in the XML</summary>
        [LxEnumValue("LY")]
        LY,
        /// <summary>Represents the value 'MA' in the XML</summary>
        [LxEnumValue("MA")]
        MA,
        /// <summary>Represents the value 'MC' in the XML</summary>
        [LxEnumValue("MC")]
        MC,
        /// <summary>Represents the value 'MD' in the XML</summary>
        [LxEnumValue("MD")]
        MD,
        /// <summary>Represents the value 'ME' in the XML</summary>
        [LxEnumValue("ME")]
        ME,
        /// <summary>Represents the value 'MF' in the XML</summary>
        [LxEnumValue("MF")]
        MF,
        /// <summary>Represents the value 'MG' in the XML</summary>
        [LxEnumValue("MG")]
        MG,
        /// <summary>Represents the value 'MH' in the XML</summary>
        [LxEnumValue("MH")]
        MH,
        /// <summary>Represents the value 'MK' in the XML</summary>
        [LxEnumValue("MK")]
        MK,
        /// <summary>Represents the value 'ML' in the XML</summary>
        [LxEnumValue("ML")]
        ML,
        /// <summary>Represents the value 'MM' in the XML</summary>
        [LxEnumValue("MM")]
        MM,
        /// <summary>Represents the value 'MN' in the XML</summary>
        [LxEnumValue("MN")]
        MN,
        /// <summary>Represents the value 'MO' in the XML</summary>
        [LxEnumValue("MO")]
        MO,
        /// <summary>Represents the value 'MP' in the XML</summary>
        [LxEnumValue("MP")]
        MP,
        /// <summary>Represents the value 'MQ' in the XML</summary>
        [LxEnumValue("MQ")]
        MQ,
        /// <summary>Represents the value 'MR' in the XML</summary>
        [LxEnumValue("MR")]
        MR,
        /// <summary>Represents the value 'MS' in the XML</summary>
        [LxEnumValue("MS")]
        MS,
        /// <summary>Represents the value 'MT' in the XML</summary>
        [LxEnumValue("MT")]
        MT,
        /// <summary>Represents the value 'MU' in the XML</summary>
        [LxEnumValue("MU")]
        MU,
        /// <summary>Represents the value 'MV' in the XML</summary>
        [LxEnumValue("MV")]
        MV,
        /// <summary>Represents the value 'MW' in the XML</summary>
        [LxEnumValue("MW")]
        MW,
        /// <summary>Represents the value 'MX' in the XML</summary>
        [LxEnumValue("MX")]
        MX,
        /// <summary>Represents the value 'MY' in the XML</summary>
        [LxEnumValue("MY")]
        MY,
        /// <summary>Represents the value 'MZ' in the XML</summary>
        [LxEnumValue("MZ")]
        MZ,
        /// <summary>Represents the value 'NA' in the XML</summary>
        [LxEnumValue("NA")]
        NA,
        /// <summary>Represents the value 'NC' in the XML</summary>
        [LxEnumValue("NC")]
        NC,
        /// <summary>Represents the value 'NE' in the XML</summary>
        [LxEnumValue("NE")]
        NE,
        /// <summary>Represents the value 'NF' in the XML</summary>
        [LxEnumValue("NF")]
        NF,
        /// <summary>Represents the value 'NG' in the XML</summary>
        [LxEnumValue("NG")]
        NG,
        /// <summary>Represents the value 'NI' in the XML</summary>
        [LxEnumValue("NI")]
        NI,
        /// <summary>Represents the value 'NL' in the XML</summary>
        [LxEnumValue("NL")]
        NL,
        /// <summary>Represents the value 'NO' in the XML</summary>
        [LxEnumValue("NO")]
        NO,
        /// <summary>Represents the value 'NP' in the XML</summary>
        [LxEnumValue("NP")]
        NP,
        /// <summary>Represents the value 'NR' in the XML</summary>
        [LxEnumValue("NR")]
        NR,
        /// <summary>Represents the value 'NU' in the XML</summary>
        [LxEnumValue("NU")]
        NU,
        /// <summary>Represents the value 'NZ' in the XML</summary>
        [LxEnumValue("NZ")]
        NZ,
        /// <summary>Represents the value 'OM' in the XML</summary>
        [LxEnumValue("OM")]
        OM,
        /// <summary>Represents the value 'PA' in the XML</summary>
        [LxEnumValue("PA")]
        PA,
        /// <summary>Represents the value 'PE' in the XML</summary>
        [LxEnumValue("PE")]
        PE,
        /// <summary>Represents the value 'PF' in the XML</summary>
        [LxEnumValue("PF")]
        PF,
        /// <summary>Represents the value 'PG' in the XML</summary>
        [LxEnumValue("PG")]
        PG,
        /// <summary>Represents the value 'PH' in the XML</summary>
        [LxEnumValue("PH")]
        PH,
        /// <summary>Represents the value 'PK' in the XML</summary>
        [LxEnumValue("PK")]
        PK,
        /// <summary>Represents the value 'PL' in the XML</summary>
        [LxEnumValue("PL")]
        PL,
        /// <summary>Represents the value 'PM' in the XML</summary>
        [LxEnumValue("PM")]
        PM,
        /// <summary>Represents the value 'PN' in the XML</summary>
        [LxEnumValue("PN")]
        PN,
        /// <summary>Represents the value 'PR' in the XML</summary>
        [LxEnumValue("PR")]
        PR,
        /// <summary>Represents the value 'PS' in the XML</summary>
        [LxEnumValue("PS")]
        PS,
        /// <summary>Represents the value 'PT' in the XML</summary>
        [LxEnumValue("PT")]
        PT,
        /// <summary>Represents the value 'PW' in the XML</summary>
        [LxEnumValue("PW")]
        PW,
        /// <summary>Represents the value 'PY' in the XML</summary>
        [LxEnumValue("PY")]
        PY,
        /// <summary>Represents the value 'QA' in the XML</summary>
        [LxEnumValue("QA")]
        QA,
        /// <summary>Represents the value 'RE' in the XML</summary>
        [LxEnumValue("RE")]
        RE,
        /// <summary>Represents the value 'RO' in the XML</summary>
        [LxEnumValue("RO")]
        RO,
        /// <summary>Represents the value 'RS' in the XML</summary>
        [LxEnumValue("RS")]
        RS,
        /// <summary>Represents the value 'RU' in the XML</summary>
        [LxEnumValue("RU")]
        RU,
        /// <summary>Represents the value 'RW' in the XML</summary>
        [LxEnumValue("RW")]
        RW,
        /// <summary>Represents the value 'SA' in the XML</summary>
        [LxEnumValue("SA")]
        SA,
        /// <summary>Represents the value 'SB' in the XML</summary>
        [LxEnumValue("SB")]
        SB,
        /// <summary>Represents the value 'SC' in the XML</summary>
        [LxEnumValue("SC")]
        SC,
        /// <summary>Represents the value 'SD' in the XML</summary>
        [LxEnumValue("SD")]
        SD,
        /// <summary>Represents the value 'SE' in the XML</summary>
        [LxEnumValue("SE")]
        SE,
        /// <summary>Represents the value 'SG' in the XML</summary>
        [LxEnumValue("SG")]
        SG,
        /// <summary>Represents the value 'SH' in the XML</summary>
        [LxEnumValue("SH")]
        SH,
        /// <summary>Represents the value 'SI' in the XML</summary>
        [LxEnumValue("SI")]
        SI,
        /// <summary>Represents the value 'SJ' in the XML</summary>
        [LxEnumValue("SJ")]
        SJ,
        /// <summary>Represents the value 'SK' in the XML</summary>
        [LxEnumValue("SK")]
        SK,
        /// <summary>Represents the value 'SL' in the XML</summary>
        [LxEnumValue("SL")]
        SL,
        /// <summary>Represents the value 'SM' in the XML</summary>
        [LxEnumValue("SM")]
        SM,
        /// <summary>Represents the value 'SN' in the XML</summary>
        [LxEnumValue("SN")]
        SN,
        /// <summary>Represents the value 'SO' in the XML</summary>
        [LxEnumValue("SO")]
        SO,
        /// <summary>Represents the value 'SR' in the XML</summary>
        [LxEnumValue("SR")]
        SR,
        /// <summary>Represents the value 'ST' in the XML</summary>
        [LxEnumValue("ST")]
        ST,
        /// <summary>Represents the value 'SV' in the XML</summary>
        [LxEnumValue("SV")]
        SV,
        /// <summary>Represents the value 'SY' in the XML</summary>
        [LxEnumValue("SY")]
        SY,
        /// <summary>Represents the value 'SZ' in the XML</summary>
        [LxEnumValue("SZ")]
        SZ,
        /// <summary>Represents the value 'TC' in the XML</summary>
        [LxEnumValue("TC")]
        TC,
        /// <summary>Represents the value 'TD' in the XML</summary>
        [LxEnumValue("TD")]
        TD,
        /// <summary>Represents the value 'TF' in the XML</summary>
        [LxEnumValue("TF")]
        TF,
        /// <summary>Represents the value 'TG' in the XML</summary>
        [LxEnumValue("TG")]
        TG,
        /// <summary>Represents the value 'TH' in the XML</summary>
        [LxEnumValue("TH")]
        TH,
        /// <summary>Represents the value 'TJ' in the XML</summary>
        [LxEnumValue("TJ")]
        TJ,
        /// <summary>Represents the value 'TK' in the XML</summary>
        [LxEnumValue("TK")]
        TK,
        /// <summary>Represents the value 'TL' in the XML</summary>
        [LxEnumValue("TL")]
        TL,
        /// <summary>Represents the value 'TM' in the XML</summary>
        [LxEnumValue("TM")]
        TM,
        /// <summary>Represents the value 'TN' in the XML</summary>
        [LxEnumValue("TN")]
        TN,
        /// <summary>Represents the value 'TO' in the XML</summary>
        [LxEnumValue("TO")]
        TO_,
        /// <summary>Represents the value 'TR' in the XML</summary>
        [LxEnumValue("TR")]
        TR,
        /// <summary>Represents the value 'TT' in the XML</summary>
        [LxEnumValue("TT")]
        TT,
        /// <summary>Represents the value 'TV' in the XML</summary>
        [LxEnumValue("TV")]
        TV,
        /// <summary>Represents the value 'TW' in the XML</summary>
        [LxEnumValue("TW")]
        TW,
        /// <summary>Represents the value 'TZ' in the XML</summary>
        [LxEnumValue("TZ")]
        TZ,
        /// <summary>Represents the value 'UA' in the XML</summary>
        [LxEnumValue("UA")]
        UA,
        /// <summary>Represents the value 'UG' in the XML</summary>
        [LxEnumValue("UG")]
        UG,
        /// <summary>Represents the value 'UM' in the XML</summary>
        [LxEnumValue("UM")]
        UM,
        /// <summary>Represents the value 'US' in the XML</summary>
        [LxEnumValue("US")]
        US,
        /// <summary>Represents the value 'UY' in the XML</summary>
        [LxEnumValue("UY")]
        UY,
        /// <summary>Represents the value 'UZ' in the XML</summary>
        [LxEnumValue("UZ")]
        UZ,
        /// <summary>Represents the value 'VA' in the XML</summary>
        [LxEnumValue("VA")]
        VA,
        /// <summary>Represents the value 'VC' in the XML</summary>
        [LxEnumValue("VC")]
        VC,
        /// <summary>Represents the value 'VE' in the XML</summary>
        [LxEnumValue("VE")]
        VE,
        /// <summary>Represents the value 'VG' in the XML</summary>
        [LxEnumValue("VG")]
        VG,
        /// <summary>Represents the value 'VI' in the XML</summary>
        [LxEnumValue("VI")]
        VI,
        /// <summary>Represents the value 'VN' in the XML</summary>
        [LxEnumValue("VN")]
        VN,
        /// <summary>Represents the value 'VU' in the XML</summary>
        [LxEnumValue("VU")]
        VU,
        /// <summary>Represents the value 'WF' in the XML</summary>
        [LxEnumValue("WF")]
        WF,
        /// <summary>Represents the value 'WS' in the XML</summary>
        [LxEnumValue("WS")]
        WS,
        /// <summary>Represents the value 'YE' in the XML</summary>
        [LxEnumValue("YE")]
        YE,
        /// <summary>Represents the value 'YT' in the XML</summary>
        [LxEnumValue("YT")]
        YT,
        /// <summary>Represents the value 'ZA' in the XML</summary>
        [LxEnumValue("ZA")]
        ZA,
        /// <summary>Represents the value 'ZM' in the XML</summary>
        [LxEnumValue("ZM")]
        ZM,
        /// <summary>Represents the value 'ZW' in the XML</summary>
        [LxEnumValue("ZW")]
        ZW,
    }
    /// <summary>An enumeration representing XSD simple type TipoImpuesto@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/simpleType:TipoImpuesto</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>1108:2-1118:18</XsdLocation>
    public enum TipoImpuestoEnum
    {
        /// <summary>Represents the value 'IVA' in the XML</summary>
        [LxEnumValue("IVA")]
        IVA,
        /// <summary>Represents the value 'PETROLEO' in the XML</summary>
        [LxEnumValue("PETROLEO")]
        PETROLEO,
        /// <summary>Represents the value 'TURISMO HOSPEDAJE' in the XML</summary>
        [LxEnumValue("TURISMO HOSPEDAJE")]
        TURISMO_HOSPEDAJE,
        /// <summary>Represents the value 'TURISMO PASAJES' in the XML</summary>
        [LxEnumValue("TURISMO PASAJES")]
        TURISMO_PASAJES,
        /// <summary>Represents the value 'TIMBRE DE PRENSA' in the XML</summary>
        [LxEnumValue("TIMBRE DE PRENSA")]
        TIMBRE_DE_PRENSA,
        /// <summary>Represents the value 'BOMBEROS' in the XML</summary>
        [LxEnumValue("BOMBEROS")]
        BOMBEROS,
        /// <summary>Represents the value 'TASA MUNICIPAL' in the XML</summary>
        [LxEnumValue("TASA MUNICIPAL")]
        TASA_MUNICIPAL,
    }
    /// <summary>An enumeration representing XSD simple type tipoMoneda@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <remarks>ISO 4217</remarks>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/simpleType:tipoMoneda</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>784:2-818:18</XsdLocation>
    public enum TipoMonedaEnum
    {
        /// <summary>Represents the value 'GTQ' in the XML</summary>
        [LxEnumValue("GTQ")]
        GTQ,
        /// <summary>Represents the value 'USD' in the XML</summary>
        [LxEnumValue("USD")]
        USD,
        /// <summary>Represents the value 'VES' in the XML</summary>
        [LxEnumValue("VES")]
        VES,
        /// <summary>Represents the value 'CRC' in the XML</summary>
        [LxEnumValue("CRC")]
        CRC,
        /// <summary>Represents the value 'SVC' in the XML</summary>
        [LxEnumValue("SVC")]
        SVC,
        /// <summary>Represents the value 'NIO' in the XML</summary>
        [LxEnumValue("NIO")]
        NIO,
        /// <summary>Represents the value 'DKK' in the XML</summary>
        [LxEnumValue("DKK")]
        DKK,
        /// <summary>Represents the value 'NOK' in the XML</summary>
        [LxEnumValue("NOK")]
        NOK,
        /// <summary>Represents the value 'SEK' in the XML</summary>
        [LxEnumValue("SEK")]
        SEK,
        /// <summary>Represents the value 'CAD' in the XML</summary>
        [LxEnumValue("CAD")]
        CAD,
        /// <summary>Represents the value 'HKD' in the XML</summary>
        [LxEnumValue("HKD")]
        HKD,
        /// <summary>Represents the value 'TWD' in the XML</summary>
        [LxEnumValue("TWD")]
        TWD,
        /// <summary>Represents the value 'PTE' in the XML</summary>
        [LxEnumValue("PTE")]
        PTE,
        /// <summary>Represents the value 'EUR' in the XML</summary>
        [LxEnumValue("EUR")]
        EUR,
        /// <summary>Represents the value 'CHF' in the XML</summary>
        [LxEnumValue("CHF")]
        CHF,
        /// <summary>Represents the value 'HNL' in the XML</summary>
        [LxEnumValue("HNL")]
        HNL,
        /// <summary>Represents the value 'GBP' in the XML</summary>
        [LxEnumValue("GBP")]
        GBP,
        /// <summary>Represents the value 'ARS' in the XML</summary>
        [LxEnumValue("ARS")]
        ARS,
        /// <summary>Represents the value 'DOP' in the XML</summary>
        [LxEnumValue("DOP")]
        DOP,
        /// <summary>Represents the value 'COP' in the XML</summary>
        [LxEnumValue("COP")]
        COP,
        /// <summary>Represents the value 'MXN' in the XML</summary>
        [LxEnumValue("MXN")]
        MXN,
        /// <summary>Represents the value 'BRL' in the XML</summary>
        [LxEnumValue("BRL")]
        BRL,
        /// <summary>Represents the value 'MYR' in the XML</summary>
        [LxEnumValue("MYR")]
        MYR,
        /// <summary>Represents the value 'INR' in the XML</summary>
        [LxEnumValue("INR")]
        INR,
        /// <summary>Represents the value 'PKR' in the XML</summary>
        [LxEnumValue("PKR")]
        PKR,
        /// <summary>Represents the value 'KPW' in the XML</summary>
        [LxEnumValue("KPW")]
        KPW,
        /// <summary>Represents the value 'JPY' in the XML</summary>
        [LxEnumValue("JPY")]
        JPY,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType tipoDireccion@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/complexType:tipoDireccion</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>730:2-783:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("tipoDireccion", "http://www.sat.gob.gt/dte/fel/0.1.0")]
    public partial class TipoDireccionCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Direccion", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "200", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Direccion { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks></remarks>
        [LxElementValue("CodigoPostal", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger CodigoPostal { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Municipio", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "100", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Municipio { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Departamento", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "100", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Departamento { get; set; } = "";

        /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.TipoCodigoPaisEnum" />, Required</summary>
        /// <remarks></remarks>
        [LxElementValue("Pais", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse)]
        public krudos.FELgt.Documento012.Dte.TipoCodigoPaisEnum Pais { get; set; }

    }

    /// <summary>A class representing the root XSD complexType tipoDocumento@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/complexType:tipoDocumento</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>714:2-714:40</XsdLocation>
    [LxSimpleComplexTypeDefinition("tipoDocumento", "http://www.sat.gob.gt/dte/fel/0.1.0")]
    public partial class TipoDocumentoCt : krudos.FELgt.Documento012.LxBase
    {
    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element GTDocumento@http://www.sat.gob.gt/dte/fel/0.1.0</summary>
    /// <remarks>Definición Global de Documento Electrónico para Guatemala.</remarks>
    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
    /// <XsdLocation>8:2-691:15</XsdLocation>
    [LxSimpleElementDefinition("GTDocumento", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.GlobalElement)]
    public partial class GTDocumentoElm : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the attribute Version</summary>
        /// <remarks>Esta casilla indica el numero de versión del documento.</remarks>
        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/attribute:Version</XsdPath>
        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
        /// <XsdLocation>685:4-689:19</XsdLocation>
        [LxAttribute("Version", "", LxValueType.Value, XsdType.XsdDecimal, Required = true)]
        public LiquidTechnologies.XmlObjects.BigDecimal Version { get; set; } = new BigDecimal(new BigInteger(new byte[] {0x04}), -1);

        /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm" />, Required : should not be set to null</summary>
        /// <remarks>Estándar de la Superintendencia de Administración Tributaria para el Documento Tributario Electrónico.</remarks>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm SAT { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignatureTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignatureElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignatureTypeCt" />
        /// </summary>
        [LxElementCt("Signature", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.SignatureTypeCt> Signatures { get; } = new List<krudos.FELgt.Documento012.Ds.SignatureTypeCt>();

        /// <summary>Represent the inline xs:element SAT@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
        /// <remarks>Estándar de la Superintendencia de Administración Tributaria para el Documento Tributario Electrónico.</remarks>
        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT</XsdPath>
        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
        /// <XsdLocation>14:5-681:18</XsdLocation>
        [LxSimpleElementDefinition("SAT", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
        public partial class SATElm : krudos.FELgt.Documento012.LxBase
        {
            /// <summary>The value for the attribute ClaseDocumento</summary>
            /// <remarks>Identificación del Documento Tributario Electrónico.</remarks>
            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/attribute:ClaseDocumento</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
            /// <XsdLocation>669:7-679:22</XsdLocation>
            [LxAttribute("ClaseDocumento", "", LxValueType.Enum, XsdType.Enum, Required = true)]
            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.ClaseDocumentoEnum ClaseDocumento { get; set; }

            /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm" />, Required : should not be set to null</summary>
            /// <remarks>Agrupa la estructura para un DTE.</remarks>
            [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm DTE { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm();

            /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.AdendaElm" />, Optional : null when not set</summary>
            /// <remarks>Elemento opcional, en el cual se puede indicar información de caracter comercial, no tributaria relacionada con el documento que el emisor le transmite al receptor.</remarks>
            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.AdendaElm Adenda { get; set; }

            /// <summary>An enumeration representing XSD simple type ClaseDocumento</summary>
            /// <remarks>Identificación del Documento Tributario Electrónico.</remarks>
            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/attribute:ClaseDocumento</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
            /// <XsdLocation>669:7-679:22</XsdLocation>
            public enum ClaseDocumentoEnum
            {
                /// <summary>Represents the value 'dte' in the XML</summary>
                [LxEnumValue("dte")]
                Dte,
            }
            /// <summary>Represent the inline xs:element DTE@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
            /// <remarks>Agrupa la estructura para un DTE.</remarks>
            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
            /// <XsdLocation>20:8-656:21</XsdLocation>
            [LxSimpleElementDefinition("DTE", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
            public partial class DTEElm : krudos.FELgt.Documento012.LxBase
            {
                /// <summary>The value for the attribute ID</summary>
                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/attribute:ID</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                /// <XsdLocation>653:10-654:12</XsdLocation>
                [LxAttribute("ID", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                public System.String ID { get; set; } = "DatosCertificados";

                /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm" />, Required : should not be set to null</summary>
                [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm DatosEmision { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm();

                /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.CertificacionElm" />, Optional : null when not set</summary>
                /// <remarks>Agrupa los datos relacionados con la autorización del DTE de parte del Certificador.</remarks>
                [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.CertificacionElm Certificacion { get; set; }

                /// <summary>Represent the inline xs:element DatosEmision@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                /// <XsdLocation>26:11-571:24</XsdLocation>
                [LxSimpleElementDefinition("DatosEmision", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                public partial class DatosEmisionElm : krudos.FELgt.Documento012.LxBase
                {
                    /// <summary>The value for the attribute ID</summary>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/attribute:ID</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>568:13-569:35</XsdLocation>
                    [LxAttribute("ID", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                    public System.String ID { get; set; } = "DatosEmision";

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa los datos generales del DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm DatosGenerales { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información del Emisor del DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm Emisor { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información del Receptor.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm Receptor { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm" />, Optional : null when not set</summary>
                    /// <remarks>Agrupa las frases de un documento.</remarks>
                    [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm Frases { get; set; }

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información de los Items.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm Items { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa los montos totales a nivel de DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm Totales { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm" />, Optional : null when not set</summary>
                    /// <remarks>
                    ///   a) Contiene diferentes subesquemas XSD. <br/>
                    ///   b) Sirve para integrar al DTE información adicional de interés para la SAT.
                    /// </remarks>
                    [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm Complementos { get; set; }

                    /// <summary>Represent the inline xs:element DatosGenerales@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa los datos generales del DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>29:13-94:26</XsdLocation>
                    [LxSimpleElementDefinition("DatosGenerales", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class DatosGeneralesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute Tipo</summary>
                        /// <remarks>Código que indica si el DTE es una factura, una nota de crédito, una nota de débito, un recibo, etc.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Tipo</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>34:13-53:28</XsdLocation>
                        [LxAttribute("Tipo", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm.TipoEnum Tipo { get; set; }

                        /// <summary>The value for the optional attribute Exp</summary>
                        /// <remarks>Indica si el DTE servira para una Exportación</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Exp</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>54:13-63:28</XsdLocation>
                        [LxAttribute("Exp", "", LxValueType.Enum, XsdType.Enum)]
                        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm.ExpEnum? Exp { get; set; }

                        /// <summary>The value for the attribute FechaHoraEmision</summary>
                        /// <remarks>Fecha y hora de emisión del DTE. Formato  aaaa-mm-ddThh:mm:ss.000-06:00 (Milisegundos opcionales, zona horaria especificada o interpretada como hora de Guatemala.)</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:FechaHoraEmision</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>64:13-74:28</XsdLocation>
                        [LxAttribute("FechaHoraEmision", "", LxValueType.Value, XsdType.XsdDateTime, Required = true, Pattern = "((\\d{4})-(\\d{2})-(\\d{2})T(\\d{2}):(\\d{2}):(\\d{2})(.(\\d{3}))?(-06:00)?)")]
                        public LiquidTechnologies.XmlObjects.LxDateTime FechaHoraEmision { get; set; }

                        /// <summary>The value for the attribute CodigoMoneda</summary>
                        /// <remarks>Código de la moneda en la que se emite el DTE.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:CodigoMoneda</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>75:13-80:28</XsdLocation>
                        [LxAttribute("CodigoMoneda", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.Dte.TipoMonedaEnum CodigoMoneda { get; set; }

                        /// <summary>The value for the optional attribute NumeroAcceso</summary>
                        /// <remarks>Es un número generado por el Emisor en forma aleatoria, que va desde 100000000 hasta 999999999</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:NumeroAcceso</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>81:13-92:28</XsdLocation>
                        [LxAttribute("NumeroAcceso", "", LxValueType.Value, XsdType.XsdPositiveInteger, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "999999999", MinInclusive = "100000000")]
                        public System.Numerics.BigInteger? NumeroAcceso { get; set; }

                        /// <summary>An enumeration representing XSD simple type Tipo</summary>
                        /// <remarks>Código que indica si el DTE es una factura, una nota de crédito, una nota de débito, un recibo, etc.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Tipo</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>34:13-53:28</XsdLocation>
                        public enum TipoEnum
                        {
                            /// <summary>Represents the value 'FACT' in the XML</summary>
                            [LxEnumValue("FACT")]
                            FACT,
                            /// <summary>Represents the value 'FCAM' in the XML</summary>
                            [LxEnumValue("FCAM")]
                            FCAM,
                            /// <summary>Represents the value 'FPEQ' in the XML</summary>
                            [LxEnumValue("FPEQ")]
                            FPEQ,
                            /// <summary>Represents the value 'FCAP' in the XML</summary>
                            [LxEnumValue("FCAP")]
                            FCAP,
                            /// <summary>Represents the value 'FESP' in the XML</summary>
                            [LxEnumValue("FESP")]
                            FESP,
                            /// <summary>Represents the value 'NABN' in the XML</summary>
                            [LxEnumValue("NABN")]
                            NABN,
                            /// <summary>Represents the value 'RDON' in the XML</summary>
                            [LxEnumValue("RDON")]
                            RDON,
                            /// <summary>Represents the value 'RECI' in the XML</summary>
                            [LxEnumValue("RECI")]
                            RECI,
                            /// <summary>Represents the value 'NDEB' in the XML</summary>
                            [LxEnumValue("NDEB")]
                            NDEB,
                            /// <summary>Represents the value 'NCRE' in the XML</summary>
                            [LxEnumValue("NCRE")]
                            NCRE,
                        }
                        /// <summary>An enumeration representing XSD simple type Exp</summary>
                        /// <remarks>Indica si el DTE servira para una Exportación</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Exp</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>54:13-63:28</XsdLocation>
                        public enum ExpEnum
                        {
                            /// <summary>Represents the value 'SI' in the XML</summary>
                            [LxEnumValue("SI")]
                            SI,
                        }
                    }

                    /// <summary>Represent the inline xs:element Emisor@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa la información del Emisor del DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>95:13-174:26</XsdLocation>
                    [LxSimpleElementDefinition("Emisor", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class EmisorElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute NITEmisor</summary>
                        /// <remarks>Indica el NIT del Emisor del DTE (sin guión).</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NITEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>108:13-113:28</XsdLocation>
                        [LxAttribute("NITEmisor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "13", Pattern = "([1-9])+([0-9])*([0-9]|K)", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NITEmisor { get; set; } = "";

                        /// <summary>The value for the attribute NombreEmisor</summary>
                        /// <remarks>Nombres y apellidos o razón social del Emisor (De acuerdo a los registros tributarios en el momento de la emisión).</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NombreEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>114:13-125:28</XsdLocation>
                        [LxAttribute("NombreEmisor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreEmisor { get; set; } = "";

                        /// <summary>The value for the attribute CodigoEstablecimiento</summary>
                        /// <remarks>Número del establecimiento donde se emite el documento. Es el que aparece asignado por SAT en sus registros.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:CodigoEstablecimiento</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>126:13-137:28</XsdLocation>
                        [LxAttribute("CodigoEstablecimiento", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "9999", MinInclusive = "1")]
                        public System.Numerics.BigInteger CodigoEstablecimiento { get; set; }

                        /// <summary>The value for the attribute NombreComercial</summary>
                        /// <remarks>Indica el nombre comercial del establecimiento (de acuerdo a los registros tributarios) donde se emite el documento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NombreComercial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>138:13-150:28</XsdLocation>
                        [LxAttribute("NombreComercial", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreComercial { get; set; } = "";

                        /// <summary>The value for the optional attribute CorreoEmisor</summary>
                        /// <remarks>Indica la Dirección de correo electrónico del Emisor.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:CorreoEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>151:13-160:28</XsdLocation>
                        [LxAttribute("CorreoEmisor", "", LxValueType.Value, XsdType.XsdString, Pattern = "((\\w[-+._\\w]+@\\w[-.\\w]+\\.\\w[-.\\w]+)(;?))*", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String CorreoEmisor { get; set; }

                        /// <summary>The value for the attribute AfiliacionIVA</summary>
                        /// <remarks>De acuerdo al Régimen que tenga registrado el contribuyente, se refiere a que puede ser General/Exento o Pequeño Contribuyente.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:AfiliacionIVA</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>161:13-172:28</XsdLocation>
                        [LxAttribute("AfiliacionIVA", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm.AfiliacionIVAEnum AfiliacionIVA { get; set; }

                        /// <summary>
                        ///   A class derived from <see cref="krudos.FELgt.Documento012.Dte.TipoDireccionCt" />.<br/><br/>
                        ///   Allowable types are <br/>
                        ///       <see cref="krudos.FELgt.Documento012.Dte.TipoDireccionCt" />
                        /// </summary>
                        /// <remarks>Agrupa los datos de la dirección del establecimiento del Emisor.</remarks>
                        [LxElementCt("DireccionEmisor", "http://www.sat.gob.gt/dte/fel/0.1.0", MinOccurs = 1, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.Dte.TipoDireccionCt DireccionEmisor { get; set; } = new krudos.FELgt.Documento012.Dte.TipoDireccionCt();

                        /// <summary>An enumeration representing XSD simple type AfiliacionIVA</summary>
                        /// <remarks>De acuerdo al Régimen que tenga registrado el contribuyente, se refiere a que puede ser General/Exento o Pequeño Contribuyente.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:AfiliacionIVA</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>161:13-172:28</XsdLocation>
                        public enum AfiliacionIVAEnum
                        {
                            /// <summary>Represents the value 'GEN' in the XML</summary>
                            [LxEnumValue("GEN")]
                            GEN,
                            /// <summary>Represents the value 'EXE' in the XML</summary>
                            [LxEnumValue("EXE")]
                            EXE,
                            /// <summary>Represents the value 'PEQ' in the XML</summary>
                            [LxEnumValue("PEQ")]
                            PEQ,
                        }
                    }

                    /// <summary>Represent the inline xs:element Receptor@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa la información del Receptor.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>175:13-234:26</XsdLocation>
                    [LxSimpleElementDefinition("Receptor", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class ReceptorElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute IDReceptor</summary>
                        /// <remarks>Indica el NIT o CUI del RECEPTOR, CF.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:IDReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>188:13-198:28</XsdLocation>
                        [LxAttribute("IDReceptor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "13", Pattern = "(([1-9])+([0-9])*([0-9]|K))|(([1-9]+[0-9]){12,13})|(CF)", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String IDReceptor { get; set; } = "";

                        /// <summary>The value for the optional attribute TipoEspecial</summary>
                        /// <remarks>Cuando la casilla está llena debe contener el valor “CUI”, lo que significa que la casilla “IDReceptor” no incluye un NIT sino un CUI.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:TipoEspecial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>199:13-209:28</XsdLocation>
                        [LxAttribute("TipoEspecial", "", LxValueType.Enum, XsdType.Enum)]
                        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm.TipoEspecialEnum? TipoEspecial { get; set; }

                        /// <summary>The value for the attribute NombreReceptor</summary>
                        /// <remarks>Si la casilla “IDReceptor” contiene un NIT valido el nombre indicado debe corresponder a los registros tributarios. Caso contrario el contenido puede ser cualquiera que solicite el RECEPTOR.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:NombreReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>210:13-222:28</XsdLocation>
                        [LxAttribute("NombreReceptor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreReceptor { get; set; } = "";

                        /// <summary>The value for the optional attribute CorreoReceptor</summary>
                        /// <remarks>Indica la Dirección de correo electrónico del receptor.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:CorreoReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>223:13-232:28</XsdLocation>
                        [LxAttribute("CorreoReceptor", "", LxValueType.Value, XsdType.XsdString, Pattern = "((\\w[-+._\\w]+@\\w[-.\\w]+\\.\\w[-.\\w]+)(;?))*", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String CorreoReceptor { get; set; }

                        /// <summary>
                        ///   A class derived from <see cref="krudos.FELgt.Documento012.Dte.TipoDireccionCt" />.<br/><br/>
                        ///   Allowable types are <br/>
                        ///       <see cref="krudos.FELgt.Documento012.Dte.TipoDireccionCt" />
                        /// </summary>
                        /// <remarks>Agrupa los datos de dirección del receptor.</remarks>
                        [LxElementCt("DireccionReceptor", "http://www.sat.gob.gt/dte/fel/0.1.0", MinOccurs = 0, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.Dte.TipoDireccionCt DireccionReceptor { get; set; }

                        /// <summary>An enumeration representing XSD simple type TipoEspecial</summary>
                        /// <remarks>Cuando la casilla está llena debe contener el valor “CUI”, lo que significa que la casilla “IDReceptor” no incluye un NIT sino un CUI.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:TipoEspecial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>199:13-209:28</XsdLocation>
                        public enum TipoEspecialEnum
                        {
                            /// <summary>Represents the value 'CUI' in the XML</summary>
                            [LxEnumValue("CUI")]
                            CUI,
                        }
                    }

                    /// <summary>Represent the inline xs:element Frases@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa las frases de un documento.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>235:13-279:26</XsdLocation>
                    [LxSimpleElementDefinition("Frases", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class FrasesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm" /></summary>
                        /// <remarks>En esta sección deberá indicarse los regímenes y textos especiales que son requeridos en los DTE, de acuerdo a la afiliación del contribuyente y tipo de operación.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm> Frases { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm>();

                        /// <summary>Represent the inline xs:element Frase@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                        /// <remarks>En esta sección deberá indicarse los regímenes y textos especiales que son requeridos en los DTE, de acuerdo a la afiliación del contribuyente y tipo de operación.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>241:13-276:26</XsdLocation>
                        [LxSimpleElementDefinition("Frase", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                        public partial class FraseElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the attribute TipoFrase</summary>
                            /// <remarks>Identifica un determinado catálogo de leyendas.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:TipoFrase</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>247:13-262:28</XsdLocation>
                            [LxAttribute("TipoFrase", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "4", MinInclusive = "1")]
                            public System.Numerics.BigInteger TipoFrase { get; set; }

                            /// <summary>The value for the attribute CodigoEscenario</summary>
                            /// <remarks>Indica un determinado Escenario dentro del catálogo de leyendas.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:CodigoEscenario</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>263:13-274:28</XsdLocation>
                            [LxAttribute("CodigoEscenario", "", LxValueType.Value, XsdType.XsdInt, Required = true, MaxInclusive = "99", MinInclusive = "1")]
                            public System.Int32 CodigoEscenario { get; set; }

                        }

                    }

                    /// <summary>Represent the inline xs:element Items@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa la información de los Items.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>280:13-482:26</XsdLocation>
                    [LxSimpleElementDefinition("Items", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class ItemsElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm" /></summary>
                        /// <remarks>Agrupa la información de un renglón o ítem de un DTE. Se refiere a lo que la Ley del IVA define como “concepto” en la venta de bienes o como “clase de servicio” en la prestación de servicios. También se refiere a lo que el Reglamento de la Ley del IVA indica como “detalle” o “descripción” de la venta, del servicio prestado o del arrendamiento.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm> Items { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm>();

                        /// <summary>Represent the inline xs:element Item@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                        /// <remarks>Agrupa la información de un renglón o ítem de un DTE. Se refiere a lo que la Ley del IVA define como “concepto” en la venta de bienes o como “clase de servicio” en la prestación de servicios. También se refiere a lo que el Reglamento de la Ley del IVA indica como “detalle” o “descripción” de la venta, del servicio prestado o del arrendamiento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>286:13-479:26</XsdLocation>
                        [LxSimpleElementDefinition("Item", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                        public partial class ItemElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the attribute NumeroLinea</summary>
                            /// <remarks>Correlativo del ítem dentro del DTE. En el caso de Notas de Débito y Notas de Crédito identifica el renglón o ítem del documento original.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:NumeroLinea</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>454:13-464:28</XsdLocation>
                            [LxAttribute("NumeroLinea", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "9999", MinInclusive = "1")]
                            public System.Numerics.BigInteger NumeroLinea { get; set; }

                            /// <summary>The value for the attribute BienOServicio</summary>
                            /// <remarks>Indica si el ítem es un bien o servicio.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:BienOServicio</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>465:13-477:28</XsdLocation>
                            [LxAttribute("BienOServicio", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.BienOServicioEnum BienOServicio { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Indica la cantidad de unidades del ítem.</remarks>
                            [LxElementValue("Cantidad", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Cantidad { get; set; }

                            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
                            /// <remarks>Indica la unidad de medida en que está expresado el elemento CantidadItem.  Si el emisor lo desea, puede utilizar la nomenclatura definida por la Intendencia de Aduanas de la SAT en su tabla SAT-IA-008.</remarks>
                            [LxElementValue("UnidadMedida", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3", WhiteSpace = WhiteSpaceType.Collapse)]
                            public System.String UnidadMedida { get; set; }

                            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                            /// <remarks>Indica la descripción del ítem.</remarks>
                            [LxElementValue("Descripcion", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "10000", WhiteSpace = WhiteSpaceType.Collapse)]
                            public System.String Descripcion { get; set; } = "";

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Precio de cada unidad del ítem en la moneda en que se emite el DTE (quetzales, dólares, euros, etc.).</remarks>
                            [LxElementValue("PrecioUnitario", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                            public LiquidTechnologies.XmlObjects.BigDecimal PrecioUnitario { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>PrecioUnitario multiplicado por CantidadItem.</remarks>
                            [LxElementValue("Precio", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Precio { get; set; }

                            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                            /// <remarks>Indica el descuento a aplicar sobre el elemento Precio.</remarks>
                            [LxElementValue("Descuento", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                            public LiquidTechnologies.XmlObjects.BigDecimal? Descuento { get; set; }

                            /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm" />, Optional : null when not set</summary>
                            /// <remarks>Agrupa los impuestos aplicados al ítem.</remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm Impuestos { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Precio menos Descuento más la sumatoria de las casillas “MontoImpuesto” (de los impuestos que sean sumables al DTE.</remarks>
                            [LxElementValue("Total", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Total { get; set; }

                            /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm" />, Optional : null when not set</summary>
                            /// <remarks>
                            ///   a) Contiene diferentes subesquemas XSD. <br/>
                            ///   b) Sirve para integrar al ítem información adicional de interés para la SAT.
                            /// </remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                            public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm ComplementosItem { get; set; }

                            /// <summary>An enumeration representing XSD simple type BienOServicio</summary>
                            /// <remarks>Indica si el ítem es un bien o servicio.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:BienOServicio</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>465:13-477:28</XsdLocation>
                            public enum BienOServicioEnum
                            {
                                /// <summary>Represents the value 'B' in the XML</summary>
                                [LxEnumValue("B")]
                                B,
                                /// <summary>Represents the value 'S' in the XML</summary>
                                [LxEnumValue("S")]
                                S,
                            }
                            /// <summary>Represent the inline xs:element Impuestos@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                            /// <remarks>Agrupa los impuestos aplicados al ítem.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:Impuestos</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>348:13-409:26</XsdLocation>
                            [LxSimpleElementDefinition("Impuestos", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                            public partial class ImpuestosElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm" /></summary>
                                /// <remarks>Agrupa los datos de un Impuesto.</remarks>
                                [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                                public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm> Impuestos { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm>();

                                /// <summary>Represent the inline xs:element Impuesto@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                                /// <remarks>Agrupa los datos de un Impuesto.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:Impuestos/sequence/element:Impuesto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                /// <XsdLocation>355:13-406:26</XsdLocation>
                                [LxSimpleElementDefinition("Impuesto", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                                public partial class ImpuestoElm : krudos.FELgt.Documento012.LxBase
                                {
                                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.TipoImpuestoEnum" />, Required</summary>
                                    /// <remarks>Nombre corto que identifica el impuesto.</remarks>
                                    [LxElementValue("NombreCorto", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse)]
                                    public krudos.FELgt.Documento012.Dte.TipoImpuestoEnum NombreCorto { get; set; }

                                    /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("CodigoUnidadGravable", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "7")]
                                    public System.Numerics.BigInteger CodigoUnidadGravable { get; set; }

                                    /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                                    /// <remarks>Monto sobre el cual se aplica el impuesto.</remarks>
                                    [LxElementValue("MontoGravable", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal? MontoGravable { get; set; }

                                    /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("CantidadUnidadesGravables", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal? CantidadUnidadesGravables { get; set; }

                                    /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("MontoImpuesto", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal MontoImpuesto { get; set; }

                                }

                            }

                            /// <summary>Represent the inline xs:element ComplementosItem@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                            /// <remarks>
                            ///   a) Contiene diferentes subesquemas XSD. <br/>
                            ///   b) Sirve para integrar al ítem información adicional de interés para la SAT.
                            /// </remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>416:13-452:26</XsdLocation>
                            [LxSimpleElementDefinition("ComplementosItem", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                            public partial class ComplementosItemElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm" /></summary>
                                /// <remarks>Complemento Item.</remarks>
                                [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                                public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm> ComplementoItems { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm>();

                                /// <summary>Represent the inline xs:element ComplementoItem@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                                /// <remarks>Complemento Item.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                /// <XsdLocation>423:13-449:26</XsdLocation>
                                [LxSimpleElementDefinition("ComplementoItem", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                                public partial class ComplementoItemElm : krudos.FELgt.Documento012.LxBase
                                {
                                    /// <summary>The value for the optional attribute IDComplementoItem</summary>
                                    /// <remarks>Identificador  del complemento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:IDComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                    /// <XsdLocation>431:13-435:28</XsdLocation>
                                    [LxAttribute("IDComplementoItem", "", LxValueType.Value, XsdType.XsdString)]
                                    public System.String IDComplementoItem { get; set; }

                                    /// <summary>The value for the attribute NombreComplementoItem</summary>
                                    /// <remarks>Indica el nombre del complento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:NombreComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                    /// <XsdLocation>436:13-441:28</XsdLocation>
                                    [LxAttribute("NombreComplementoItem", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                                    public System.String NombreComplementoItem { get; set; } = "";

                                    /// <summary>The value for the attribute URIComplementoItem</summary>
                                    /// <remarks>Indica el URI del XSD del complemento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:URIComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                    /// <XsdLocation>442:13-447:28</XsdLocation>
                                    [LxAttribute("URIComplementoItem", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                                    public System.String URIComplementoItem { get; set; } = "";

                                    /// <summary>An <see cref="XElement"/> to hold the additional element described by an xs:any, Required : should be set before calling Serialize.</summary>
                                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/sequence/any</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                    /// <XsdLocation>429:13-429:22</XsdLocation>
                                    [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.1.0", MinOccurs = 1, MaxOccurs = 1)]
                                    public XElement AnyElement { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>Represent the inline xs:element Totales@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Agrupa los montos totales a nivel de DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>483:13-530:26</XsdLocation>
                    [LxSimpleElementDefinition("Totales", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class TotalesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm" />, Optional : null when not set</summary>
                        /// <remarks>Agrupa los totales de impuestos agrupados por tipo de impuesto.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm TotalImpuestos { get; set; }

                        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                        /// <remarks>Sumatoria de los elementos Total de cada uno de los ítems del DTE.</remarks>
                        [LxElementValue("GranTotal", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                        public LiquidTechnologies.XmlObjects.BigDecimal GranTotal { get; set; }

                        /// <summary>Represent the inline xs:element TotalImpuestos@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                        /// <remarks>Agrupa los totales de impuestos agrupados por tipo de impuesto.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>489:13-521:26</XsdLocation>
                        [LxSimpleElementDefinition("TotalImpuestos", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                        public partial class TotalImpuestosElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm" /></summary>
                            /// <remarks>Agrupa los datos de cada impuesto.</remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                            public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm> TotalImpuestos { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm>();

                            /// <summary>Represent the inline xs:element TotalImpuesto@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                            /// <remarks>Agrupa los datos de cada impuesto.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>495:13-518:26</XsdLocation>
                            [LxSimpleElementDefinition("TotalImpuesto", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                            public partial class TotalImpuestoElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>The value for the attribute NombreCorto</summary>
                                /// <remarks>Nombre corto que identifica el impuesto.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto/attribute:NombreCorto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                /// <XsdLocation>500:13-509:28</XsdLocation>
                                [LxAttribute("NombreCorto", "", LxValueType.Value, XsdType.Enum, Required = true, WhiteSpace = WhiteSpaceType.Collapse)]
                                public krudos.FELgt.Documento012.Dte.TipoImpuestoEnum NombreCorto { get; set; }

                                /// <summary>The value for the attribute TotalMontoImpuesto</summary>
                                /// <remarks>Sumatoria de MontoImpuesto de cada uno de los ítems con el mismo impuesto. Ejemplo: Si el elemento impuesto es IVA, este atributo deberá contener la sumatoria de los montos de IVA incluidos en todos los ítems del documento.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto/attribute:TotalMontoImpuesto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                                /// <XsdLocation>510:13-516:28</XsdLocation>
                                [LxAttribute("TotalMontoImpuesto", "", LxValueType.Value, XsdType.XsdDecimal, Required = true, MinInclusive = "0", TotalDigits = "18", FractionDigits = "6")]
                                public LiquidTechnologies.XmlObjects.BigDecimal TotalMontoImpuesto { get; set; }

                            }

                        }

                    }

                    /// <summary>Represent the inline xs:element Complementos@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>
                    ///   a) Contiene diferentes subesquemas XSD. <br/>
                    ///   b) Sirve para integrar al DTE información adicional de interés para la SAT.
                    /// </remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>531:13-566:26</XsdLocation>
                    [LxSimpleElementDefinition("Complementos", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class ComplementosElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm" /></summary>
                        /// <remarks>Complemento.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm> Complementos { get; } = new List<krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm>();

                        /// <summary>Represent the inline xs:element Complemento@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                        /// <remarks>Complemento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>538:13-563:26</XsdLocation>
                        [LxSimpleElementDefinition("Complemento", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                        public partial class ComplementoElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the optional attribute IDComplemento</summary>
                            /// <remarks>Identificador del complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:IDComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>546:13-550:28</XsdLocation>
                            [LxAttribute("IDComplemento", "", LxValueType.Value, XsdType.XsdString)]
                            public System.String IDComplemento { get; set; }

                            /// <summary>The value for the attribute NombreComplemento</summary>
                            /// <remarks>Indica el nombre del Complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:NombreComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>551:13-556:28</XsdLocation>
                            [LxAttribute("NombreComplemento", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                            public System.String NombreComplemento { get; set; } = "";

                            /// <summary>The value for the attribute URIComplemento</summary>
                            /// <remarks>Indica el URI del XSD del complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:URIComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>557:13-561:28</XsdLocation>
                            [LxAttribute("URIComplemento", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                            public System.String URIComplemento { get; set; } = "";

                            /// <summary>An <see cref="XElement"/> to hold the additional element described by an xs:any, Required : should be set before calling Serialize.</summary>
                            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/sequence/any</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                            /// <XsdLocation>544:13-544:22</XsdLocation>
                            [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.1.0", MinOccurs = 1, MaxOccurs = 1)]
                            public XElement AnyElement { get; set; }

                        }

                    }

                }

                /// <summary>Represent the inline xs:element Certificacion@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                /// <remarks>Agrupa los datos relacionados con la autorización del DTE de parte del Certificador.</remarks>
                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                /// <XsdLocation>572:11-651:24</XsdLocation>
                [LxSimpleElementDefinition("Certificacion", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                public partial class CertificacionElm : krudos.FELgt.Documento012.LxBase
                {
                    /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                    /// <remarks>NIT del Certificador sin guión.</remarks>
                    [LxElementValue("NITCertificador", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "13", Pattern = "([1-9])+([0-9])*([0-9]|K)", WhiteSpace = WhiteSpaceType.Collapse)]
                    public System.String NITCertificador { get; set; } = "";

                    /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                    /// <remarks>Nombre del Certificador (De acuerdo a los registros tributarios).</remarks>
                    [LxElementValue("NombreCertificador", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                    public System.String NombreCertificador { get; set; } = "";

                    /// <summary>A <see cref="krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm" />, Required : should not be set to null</summary>
                    /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm NumeroAutorizacion { get; set; } = new krudos.FELgt.Documento012.Dte.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm();

                    /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
                    /// <remarks>Es la fecha y hora del momento en que el Certificador incorpora su firma electrónica al DTE. Formato  aaaa-mm-ddThh:mm:ss.000-06:00 (Milisegundos opcionales, zona horaria especificada o interpretada como hora de Guatemala</remarks>
                    [LxElementValue("FechaHoraCertificacion", "http://www.sat.gob.gt/dte/fel/0.1.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2})T(\\d{2}):(\\d{2}):(\\d{2})(.(\\d{3}))?(-06:00)?)")]
                    public LiquidTechnologies.XmlObjects.LxDateTime FechaHoraCertificacion { get; set; }

                    /// <summary>Represent the inline xs:element NumeroAutorizacion@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
                    /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                    /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                    /// <XsdLocation>604:13-638:26</XsdLocation>
                    [LxSimpleElementDefinition("NumeroAutorizacion", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
                    public partial class NumeroAutorizacionElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute Serie</summary>
                        /// <remarks>Se forma con los primeros 8 dígitos hexadecimales del UUID, de izquierda a derecha, de tal forma que queda estructurado como se describe a continuación: De un UUID Original: dbb51ae2-3a62-4437-b8e9-42ecfb761156, el valor resultante será: dbb51ae2</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion/attribute:Serie</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>611:13-622:28</XsdLocation>
                        [LxAttribute("Serie", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "20", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String Serie { get; set; } = "";

                        /// <summary>The value for the attribute Numero</summary>
                        /// <remarks>Se forma con el equivalente en números decimales de los dígitos hexadecimales del UUID, a partir de la posición 9 hasta la posición 16 (excluyendo los guiones “-“), de izquierda a derecha, de tal forma que queda estructurado como se describe a continuación: De un UUID Original: dbb51ae2-3a62-4437-b8e9-42ecfb761156, el valor resultante será: 979518519</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion/attribute:Numero</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>623:13-634:28</XsdLocation>
                        [LxAttribute("Numero", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "999999999999999", MinInclusive = "1", TotalDigits = "15")]
                        public System.Numerics.BigInteger Numero { get; set; }

                        /// <summary>Holds the <see cref="System.String" /> value of the element</summary>
                        /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                        /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                        /// <XsdLocation>604:13-638:26</XsdLocation>
                        [LxValue(LxValueType.Value, XsdType.XsdToken, Pattern = "[0-9A-F]{8}-([0-9A-F]{4}-){3}[0-9A-F]{12}")]
                        public System.String Value { get; set; } = "";

                    }

                }

            }

            /// <summary>Represent the inline xs:element Adenda@http://www.sat.gob.gt/dte/fel/0.1.0.</summary>
            /// <remarks>Elemento opcional, en el cual se puede indicar información de caracter comercial, no tributaria relacionada con el documento que el emisor le transmite al receptor.</remarks>
            /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:Adenda</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
            /// <XsdLocation>657:8-667:21</XsdLocation>
            [LxSimpleElementDefinition("Adenda", "http://www.sat.gob.gt/dte/fel/0.1.0", ElementScopeType.InlineElement)]
            public partial class AdendaElm : krudos.FELgt.Documento012.LxBase
            {
                /// <summary>A collection of <see cref="XElement"/>'s to hold the additional elements described by an xs:any</summary>
                /// <XsdPath>schema:GT_Documento-0.1.2.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:Adenda/sequence/any</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.1.2.xsd</XsdFile>
                /// <XsdLocation>663:11-664:35</XsdLocation>
                [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.1.0", Namespaces = new string[] { "##any"}, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                public List<XElement> AnyElements { get; } = new List<XElement>();

            }

        }

    }

    #endregion

}

namespace krudos.FELgt.Documento012.DteA
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type tipoCodigoPais@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <remarks>Código de País ISO 3166-1</remarks>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/simpleType:tipoCodigoPais</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>827:2-1083:18</XsdLocation>
    public enum TipoCodigoPaisEnum
    {
        /// <summary>Represents the value 'AD' in the XML</summary>
        [LxEnumValue("AD")]
        AD,
        /// <summary>Represents the value 'AE' in the XML</summary>
        [LxEnumValue("AE")]
        AE,
        /// <summary>Represents the value 'AF' in the XML</summary>
        [LxEnumValue("AF")]
        AF,
        /// <summary>Represents the value 'AG' in the XML</summary>
        [LxEnumValue("AG")]
        AG,
        /// <summary>Represents the value 'AI' in the XML</summary>
        [LxEnumValue("AI")]
        AI,
        /// <summary>Represents the value 'AL' in the XML</summary>
        [LxEnumValue("AL")]
        AL,
        /// <summary>Represents the value 'AM' in the XML</summary>
        [LxEnumValue("AM")]
        AM,
        /// <summary>Represents the value 'AN' in the XML</summary>
        [LxEnumValue("AN")]
        AN,
        /// <summary>Represents the value 'AO' in the XML</summary>
        [LxEnumValue("AO")]
        AO,
        /// <summary>Represents the value 'AQ' in the XML</summary>
        [LxEnumValue("AQ")]
        AQ,
        /// <summary>Represents the value 'AR' in the XML</summary>
        [LxEnumValue("AR")]
        AR,
        /// <summary>Represents the value 'AS' in the XML</summary>
        [LxEnumValue("AS")]
        AS_,
        /// <summary>Represents the value 'AT' in the XML</summary>
        [LxEnumValue("AT")]
        AT,
        /// <summary>Represents the value 'AU' in the XML</summary>
        [LxEnumValue("AU")]
        AU,
        /// <summary>Represents the value 'AW' in the XML</summary>
        [LxEnumValue("AW")]
        AW,
        /// <summary>Represents the value 'AX' in the XML</summary>
        [LxEnumValue("AX")]
        AX,
        /// <summary>Represents the value 'AZ' in the XML</summary>
        [LxEnumValue("AZ")]
        AZ,
        /// <summary>Represents the value 'BA' in the XML</summary>
        [LxEnumValue("BA")]
        BA,
        /// <summary>Represents the value 'BB' in the XML</summary>
        [LxEnumValue("BB")]
        BB,
        /// <summary>Represents the value 'BD' in the XML</summary>
        [LxEnumValue("BD")]
        BD,
        /// <summary>Represents the value 'BE' in the XML</summary>
        [LxEnumValue("BE")]
        BE,
        /// <summary>Represents the value 'BF' in the XML</summary>
        [LxEnumValue("BF")]
        BF,
        /// <summary>Represents the value 'BG' in the XML</summary>
        [LxEnumValue("BG")]
        BG,
        /// <summary>Represents the value 'BH' in the XML</summary>
        [LxEnumValue("BH")]
        BH,
        /// <summary>Represents the value 'BI' in the XML</summary>
        [LxEnumValue("BI")]
        BI,
        /// <summary>Represents the value 'BJ' in the XML</summary>
        [LxEnumValue("BJ")]
        BJ,
        /// <summary>Represents the value 'BL' in the XML</summary>
        [LxEnumValue("BL")]
        BL,
        /// <summary>Represents the value 'BM' in the XML</summary>
        [LxEnumValue("BM")]
        BM,
        /// <summary>Represents the value 'BN' in the XML</summary>
        [LxEnumValue("BN")]
        BN,
        /// <summary>Represents the value 'BO' in the XML</summary>
        [LxEnumValue("BO")]
        BO,
        /// <summary>Represents the value 'BR' in the XML</summary>
        [LxEnumValue("BR")]
        BR,
        /// <summary>Represents the value 'BS' in the XML</summary>
        [LxEnumValue("BS")]
        BS,
        /// <summary>Represents the value 'BT' in the XML</summary>
        [LxEnumValue("BT")]
        BT,
        /// <summary>Represents the value 'BV' in the XML</summary>
        [LxEnumValue("BV")]
        BV,
        /// <summary>Represents the value 'BW' in the XML</summary>
        [LxEnumValue("BW")]
        BW,
        /// <summary>Represents the value 'BY' in the XML</summary>
        [LxEnumValue("BY")]
        BY,
        /// <summary>Represents the value 'BZ' in the XML</summary>
        [LxEnumValue("BZ")]
        BZ,
        /// <summary>Represents the value 'CA' in the XML</summary>
        [LxEnumValue("CA")]
        CA,
        /// <summary>Represents the value 'CC' in the XML</summary>
        [LxEnumValue("CC")]
        CC,
        /// <summary>Represents the value 'CD' in the XML</summary>
        [LxEnumValue("CD")]
        CD,
        /// <summary>Represents the value 'CF' in the XML</summary>
        [LxEnumValue("CF")]
        CF,
        /// <summary>Represents the value 'CG' in the XML</summary>
        [LxEnumValue("CG")]
        CG,
        /// <summary>Represents the value 'CH' in the XML</summary>
        [LxEnumValue("CH")]
        CH,
        /// <summary>Represents the value 'CI' in the XML</summary>
        [LxEnumValue("CI")]
        CI,
        /// <summary>Represents the value 'CK' in the XML</summary>
        [LxEnumValue("CK")]
        CK,
        /// <summary>Represents the value 'CL' in the XML</summary>
        [LxEnumValue("CL")]
        CL,
        /// <summary>Represents the value 'CM' in the XML</summary>
        [LxEnumValue("CM")]
        CM,
        /// <summary>Represents the value 'CN' in the XML</summary>
        [LxEnumValue("CN")]
        CN,
        /// <summary>Represents the value 'CO' in the XML</summary>
        [LxEnumValue("CO")]
        CO,
        /// <summary>Represents the value 'CR' in the XML</summary>
        [LxEnumValue("CR")]
        CR,
        /// <summary>Represents the value 'CU' in the XML</summary>
        [LxEnumValue("CU")]
        CU,
        /// <summary>Represents the value 'CV' in the XML</summary>
        [LxEnumValue("CV")]
        CV,
        /// <summary>Represents the value 'CX' in the XML</summary>
        [LxEnumValue("CX")]
        CX,
        /// <summary>Represents the value 'CY' in the XML</summary>
        [LxEnumValue("CY")]
        CY,
        /// <summary>Represents the value 'CZ' in the XML</summary>
        [LxEnumValue("CZ")]
        CZ,
        /// <summary>Represents the value 'DE' in the XML</summary>
        [LxEnumValue("DE")]
        DE,
        /// <summary>Represents the value 'DJ' in the XML</summary>
        [LxEnumValue("DJ")]
        DJ,
        /// <summary>Represents the value 'DK' in the XML</summary>
        [LxEnumValue("DK")]
        DK,
        /// <summary>Represents the value 'DM' in the XML</summary>
        [LxEnumValue("DM")]
        DM,
        /// <summary>Represents the value 'DO' in the XML</summary>
        [LxEnumValue("DO")]
        DO_,
        /// <summary>Represents the value 'DZ' in the XML</summary>
        [LxEnumValue("DZ")]
        DZ,
        /// <summary>Represents the value 'EC' in the XML</summary>
        [LxEnumValue("EC")]
        EC,
        /// <summary>Represents the value 'EE' in the XML</summary>
        [LxEnumValue("EE")]
        EE,
        /// <summary>Represents the value 'EG' in the XML</summary>
        [LxEnumValue("EG")]
        EG,
        /// <summary>Represents the value 'EH' in the XML</summary>
        [LxEnumValue("EH")]
        EH,
        /// <summary>Represents the value 'ER' in the XML</summary>
        [LxEnumValue("ER")]
        ER,
        /// <summary>Represents the value 'ES' in the XML</summary>
        [LxEnumValue("ES")]
        ES,
        /// <summary>Represents the value 'ET' in the XML</summary>
        [LxEnumValue("ET")]
        ET,
        /// <summary>Represents the value 'FI' in the XML</summary>
        [LxEnumValue("FI")]
        FI,
        /// <summary>Represents the value 'FJ' in the XML</summary>
        [LxEnumValue("FJ")]
        FJ,
        /// <summary>Represents the value 'FK' in the XML</summary>
        [LxEnumValue("FK")]
        FK,
        /// <summary>Represents the value 'FM' in the XML</summary>
        [LxEnumValue("FM")]
        FM,
        /// <summary>Represents the value 'FO' in the XML</summary>
        [LxEnumValue("FO")]
        FO,
        /// <summary>Represents the value 'FR' in the XML</summary>
        [LxEnumValue("FR")]
        FR,
        /// <summary>Represents the value 'GA' in the XML</summary>
        [LxEnumValue("GA")]
        GA,
        /// <summary>Represents the value 'GB' in the XML</summary>
        [LxEnumValue("GB")]
        GB,
        /// <summary>Represents the value 'GD' in the XML</summary>
        [LxEnumValue("GD")]
        GD,
        /// <summary>Represents the value 'GE' in the XML</summary>
        [LxEnumValue("GE")]
        GE,
        /// <summary>Represents the value 'GF' in the XML</summary>
        [LxEnumValue("GF")]
        GF,
        /// <summary>Represents the value 'GG' in the XML</summary>
        [LxEnumValue("GG")]
        GG,
        /// <summary>Represents the value 'GH' in the XML</summary>
        [LxEnumValue("GH")]
        GH,
        /// <summary>Represents the value 'GI' in the XML</summary>
        [LxEnumValue("GI")]
        GI,
        /// <summary>Represents the value 'GL' in the XML</summary>
        [LxEnumValue("GL")]
        GL,
        /// <summary>Represents the value 'GM' in the XML</summary>
        [LxEnumValue("GM")]
        GM,
        /// <summary>Represents the value 'GN' in the XML</summary>
        [LxEnumValue("GN")]
        GN,
        /// <summary>Represents the value 'GP' in the XML</summary>
        [LxEnumValue("GP")]
        GP,
        /// <summary>Represents the value 'GQ' in the XML</summary>
        [LxEnumValue("GQ")]
        GQ,
        /// <summary>Represents the value 'GR' in the XML</summary>
        [LxEnumValue("GR")]
        GR,
        /// <summary>Represents the value 'GS' in the XML</summary>
        [LxEnumValue("GS")]
        GS,
        /// <summary>Represents the value 'GT' in the XML</summary>
        [LxEnumValue("GT")]
        GT,
        /// <summary>Represents the value 'GU' in the XML</summary>
        [LxEnumValue("GU")]
        GU,
        /// <summary>Represents the value 'GW' in the XML</summary>
        [LxEnumValue("GW")]
        GW,
        /// <summary>Represents the value 'GY' in the XML</summary>
        [LxEnumValue("GY")]
        GY,
        /// <summary>Represents the value 'HK' in the XML</summary>
        [LxEnumValue("HK")]
        HK,
        /// <summary>Represents the value 'HM' in the XML</summary>
        [LxEnumValue("HM")]
        HM,
        /// <summary>Represents the value 'HN' in the XML</summary>
        [LxEnumValue("HN")]
        HN,
        /// <summary>Represents the value 'HR' in the XML</summary>
        [LxEnumValue("HR")]
        HR,
        /// <summary>Represents the value 'HT' in the XML</summary>
        [LxEnumValue("HT")]
        HT,
        /// <summary>Represents the value 'HU' in the XML</summary>
        [LxEnumValue("HU")]
        HU,
        /// <summary>Represents the value 'ID' in the XML</summary>
        [LxEnumValue("ID")]
        ID,
        /// <summary>Represents the value 'IE' in the XML</summary>
        [LxEnumValue("IE")]
        IE,
        /// <summary>Represents the value 'IL' in the XML</summary>
        [LxEnumValue("IL")]
        IL,
        /// <summary>Represents the value 'IM' in the XML</summary>
        [LxEnumValue("IM")]
        IM,
        /// <summary>Represents the value 'IN' in the XML</summary>
        [LxEnumValue("IN")]
        IN_,
        /// <summary>Represents the value 'IO' in the XML</summary>
        [LxEnumValue("IO")]
        IO,
        /// <summary>Represents the value 'IQ' in the XML</summary>
        [LxEnumValue("IQ")]
        IQ,
        /// <summary>Represents the value 'IR' in the XML</summary>
        [LxEnumValue("IR")]
        IR,
        /// <summary>Represents the value 'IS' in the XML</summary>
        [LxEnumValue("IS")]
        IS_,
        /// <summary>Represents the value 'IT' in the XML</summary>
        [LxEnumValue("IT")]
        IT,
        /// <summary>Represents the value 'JE' in the XML</summary>
        [LxEnumValue("JE")]
        JE,
        /// <summary>Represents the value 'JM' in the XML</summary>
        [LxEnumValue("JM")]
        JM,
        /// <summary>Represents the value 'JO' in the XML</summary>
        [LxEnumValue("JO")]
        JO,
        /// <summary>Represents the value 'JP' in the XML</summary>
        [LxEnumValue("JP")]
        JP,
        /// <summary>Represents the value 'KE' in the XML</summary>
        [LxEnumValue("KE")]
        KE,
        /// <summary>Represents the value 'KG' in the XML</summary>
        [LxEnumValue("KG")]
        KG,
        /// <summary>Represents the value 'KH' in the XML</summary>
        [LxEnumValue("KH")]
        KH,
        /// <summary>Represents the value 'KI' in the XML</summary>
        [LxEnumValue("KI")]
        KI,
        /// <summary>Represents the value 'KM' in the XML</summary>
        [LxEnumValue("KM")]
        KM,
        /// <summary>Represents the value 'KN' in the XML</summary>
        [LxEnumValue("KN")]
        KN,
        /// <summary>Represents the value 'KP' in the XML</summary>
        [LxEnumValue("KP")]
        KP,
        /// <summary>Represents the value 'KR' in the XML</summary>
        [LxEnumValue("KR")]
        KR,
        /// <summary>Represents the value 'KW' in the XML</summary>
        [LxEnumValue("KW")]
        KW,
        /// <summary>Represents the value 'KY' in the XML</summary>
        [LxEnumValue("KY")]
        KY,
        /// <summary>Represents the value 'KZ' in the XML</summary>
        [LxEnumValue("KZ")]
        KZ,
        /// <summary>Represents the value 'LA' in the XML</summary>
        [LxEnumValue("LA")]
        LA,
        /// <summary>Represents the value 'LB' in the XML</summary>
        [LxEnumValue("LB")]
        LB,
        /// <summary>Represents the value 'LC' in the XML</summary>
        [LxEnumValue("LC")]
        LC,
        /// <summary>Represents the value 'LI' in the XML</summary>
        [LxEnumValue("LI")]
        LI,
        /// <summary>Represents the value 'LK' in the XML</summary>
        [LxEnumValue("LK")]
        LK,
        /// <summary>Represents the value 'LR' in the XML</summary>
        [LxEnumValue("LR")]
        LR,
        /// <summary>Represents the value 'LS' in the XML</summary>
        [LxEnumValue("LS")]
        LS,
        /// <summary>Represents the value 'LT' in the XML</summary>
        [LxEnumValue("LT")]
        LT,
        /// <summary>Represents the value 'LU' in the XML</summary>
        [LxEnumValue("LU")]
        LU,
        /// <summary>Represents the value 'LV' in the XML</summary>
        [LxEnumValue("LV")]
        LV,
        /// <summary>Represents the value 'LY' in the XML</summary>
        [LxEnumValue("LY")]
        LY,
        /// <summary>Represents the value 'MA' in the XML</summary>
        [LxEnumValue("MA")]
        MA,
        /// <summary>Represents the value 'MC' in the XML</summary>
        [LxEnumValue("MC")]
        MC,
        /// <summary>Represents the value 'MD' in the XML</summary>
        [LxEnumValue("MD")]
        MD,
        /// <summary>Represents the value 'ME' in the XML</summary>
        [LxEnumValue("ME")]
        ME,
        /// <summary>Represents the value 'MF' in the XML</summary>
        [LxEnumValue("MF")]
        MF,
        /// <summary>Represents the value 'MG' in the XML</summary>
        [LxEnumValue("MG")]
        MG,
        /// <summary>Represents the value 'MH' in the XML</summary>
        [LxEnumValue("MH")]
        MH,
        /// <summary>Represents the value 'MK' in the XML</summary>
        [LxEnumValue("MK")]
        MK,
        /// <summary>Represents the value 'ML' in the XML</summary>
        [LxEnumValue("ML")]
        ML,
        /// <summary>Represents the value 'MM' in the XML</summary>
        [LxEnumValue("MM")]
        MM,
        /// <summary>Represents the value 'MN' in the XML</summary>
        [LxEnumValue("MN")]
        MN,
        /// <summary>Represents the value 'MO' in the XML</summary>
        [LxEnumValue("MO")]
        MO,
        /// <summary>Represents the value 'MP' in the XML</summary>
        [LxEnumValue("MP")]
        MP,
        /// <summary>Represents the value 'MQ' in the XML</summary>
        [LxEnumValue("MQ")]
        MQ,
        /// <summary>Represents the value 'MR' in the XML</summary>
        [LxEnumValue("MR")]
        MR,
        /// <summary>Represents the value 'MS' in the XML</summary>
        [LxEnumValue("MS")]
        MS,
        /// <summary>Represents the value 'MT' in the XML</summary>
        [LxEnumValue("MT")]
        MT,
        /// <summary>Represents the value 'MU' in the XML</summary>
        [LxEnumValue("MU")]
        MU,
        /// <summary>Represents the value 'MV' in the XML</summary>
        [LxEnumValue("MV")]
        MV,
        /// <summary>Represents the value 'MW' in the XML</summary>
        [LxEnumValue("MW")]
        MW,
        /// <summary>Represents the value 'MX' in the XML</summary>
        [LxEnumValue("MX")]
        MX,
        /// <summary>Represents the value 'MY' in the XML</summary>
        [LxEnumValue("MY")]
        MY,
        /// <summary>Represents the value 'MZ' in the XML</summary>
        [LxEnumValue("MZ")]
        MZ,
        /// <summary>Represents the value 'NA' in the XML</summary>
        [LxEnumValue("NA")]
        NA,
        /// <summary>Represents the value 'NC' in the XML</summary>
        [LxEnumValue("NC")]
        NC,
        /// <summary>Represents the value 'NE' in the XML</summary>
        [LxEnumValue("NE")]
        NE,
        /// <summary>Represents the value 'NF' in the XML</summary>
        [LxEnumValue("NF")]
        NF,
        /// <summary>Represents the value 'NG' in the XML</summary>
        [LxEnumValue("NG")]
        NG,
        /// <summary>Represents the value 'NI' in the XML</summary>
        [LxEnumValue("NI")]
        NI,
        /// <summary>Represents the value 'NL' in the XML</summary>
        [LxEnumValue("NL")]
        NL,
        /// <summary>Represents the value 'NO' in the XML</summary>
        [LxEnumValue("NO")]
        NO,
        /// <summary>Represents the value 'NP' in the XML</summary>
        [LxEnumValue("NP")]
        NP,
        /// <summary>Represents the value 'NR' in the XML</summary>
        [LxEnumValue("NR")]
        NR,
        /// <summary>Represents the value 'NU' in the XML</summary>
        [LxEnumValue("NU")]
        NU,
        /// <summary>Represents the value 'NZ' in the XML</summary>
        [LxEnumValue("NZ")]
        NZ,
        /// <summary>Represents the value 'OM' in the XML</summary>
        [LxEnumValue("OM")]
        OM,
        /// <summary>Represents the value 'PA' in the XML</summary>
        [LxEnumValue("PA")]
        PA,
        /// <summary>Represents the value 'PE' in the XML</summary>
        [LxEnumValue("PE")]
        PE,
        /// <summary>Represents the value 'PF' in the XML</summary>
        [LxEnumValue("PF")]
        PF,
        /// <summary>Represents the value 'PG' in the XML</summary>
        [LxEnumValue("PG")]
        PG,
        /// <summary>Represents the value 'PH' in the XML</summary>
        [LxEnumValue("PH")]
        PH,
        /// <summary>Represents the value 'PK' in the XML</summary>
        [LxEnumValue("PK")]
        PK,
        /// <summary>Represents the value 'PL' in the XML</summary>
        [LxEnumValue("PL")]
        PL,
        /// <summary>Represents the value 'PM' in the XML</summary>
        [LxEnumValue("PM")]
        PM,
        /// <summary>Represents the value 'PN' in the XML</summary>
        [LxEnumValue("PN")]
        PN,
        /// <summary>Represents the value 'PR' in the XML</summary>
        [LxEnumValue("PR")]
        PR,
        /// <summary>Represents the value 'PS' in the XML</summary>
        [LxEnumValue("PS")]
        PS,
        /// <summary>Represents the value 'PT' in the XML</summary>
        [LxEnumValue("PT")]
        PT,
        /// <summary>Represents the value 'PW' in the XML</summary>
        [LxEnumValue("PW")]
        PW,
        /// <summary>Represents the value 'PY' in the XML</summary>
        [LxEnumValue("PY")]
        PY,
        /// <summary>Represents the value 'QA' in the XML</summary>
        [LxEnumValue("QA")]
        QA,
        /// <summary>Represents the value 'RE' in the XML</summary>
        [LxEnumValue("RE")]
        RE,
        /// <summary>Represents the value 'RO' in the XML</summary>
        [LxEnumValue("RO")]
        RO,
        /// <summary>Represents the value 'RS' in the XML</summary>
        [LxEnumValue("RS")]
        RS,
        /// <summary>Represents the value 'RU' in the XML</summary>
        [LxEnumValue("RU")]
        RU,
        /// <summary>Represents the value 'RW' in the XML</summary>
        [LxEnumValue("RW")]
        RW,
        /// <summary>Represents the value 'SA' in the XML</summary>
        [LxEnumValue("SA")]
        SA,
        /// <summary>Represents the value 'SB' in the XML</summary>
        [LxEnumValue("SB")]
        SB,
        /// <summary>Represents the value 'SC' in the XML</summary>
        [LxEnumValue("SC")]
        SC,
        /// <summary>Represents the value 'SD' in the XML</summary>
        [LxEnumValue("SD")]
        SD,
        /// <summary>Represents the value 'SE' in the XML</summary>
        [LxEnumValue("SE")]
        SE,
        /// <summary>Represents the value 'SG' in the XML</summary>
        [LxEnumValue("SG")]
        SG,
        /// <summary>Represents the value 'SH' in the XML</summary>
        [LxEnumValue("SH")]
        SH,
        /// <summary>Represents the value 'SI' in the XML</summary>
        [LxEnumValue("SI")]
        SI,
        /// <summary>Represents the value 'SJ' in the XML</summary>
        [LxEnumValue("SJ")]
        SJ,
        /// <summary>Represents the value 'SK' in the XML</summary>
        [LxEnumValue("SK")]
        SK,
        /// <summary>Represents the value 'SL' in the XML</summary>
        [LxEnumValue("SL")]
        SL,
        /// <summary>Represents the value 'SM' in the XML</summary>
        [LxEnumValue("SM")]
        SM,
        /// <summary>Represents the value 'SN' in the XML</summary>
        [LxEnumValue("SN")]
        SN,
        /// <summary>Represents the value 'SO' in the XML</summary>
        [LxEnumValue("SO")]
        SO,
        /// <summary>Represents the value 'SR' in the XML</summary>
        [LxEnumValue("SR")]
        SR,
        /// <summary>Represents the value 'ST' in the XML</summary>
        [LxEnumValue("ST")]
        ST,
        /// <summary>Represents the value 'SV' in the XML</summary>
        [LxEnumValue("SV")]
        SV,
        /// <summary>Represents the value 'SY' in the XML</summary>
        [LxEnumValue("SY")]
        SY,
        /// <summary>Represents the value 'SZ' in the XML</summary>
        [LxEnumValue("SZ")]
        SZ,
        /// <summary>Represents the value 'TC' in the XML</summary>
        [LxEnumValue("TC")]
        TC,
        /// <summary>Represents the value 'TD' in the XML</summary>
        [LxEnumValue("TD")]
        TD,
        /// <summary>Represents the value 'TF' in the XML</summary>
        [LxEnumValue("TF")]
        TF,
        /// <summary>Represents the value 'TG' in the XML</summary>
        [LxEnumValue("TG")]
        TG,
        /// <summary>Represents the value 'TH' in the XML</summary>
        [LxEnumValue("TH")]
        TH,
        /// <summary>Represents the value 'TJ' in the XML</summary>
        [LxEnumValue("TJ")]
        TJ,
        /// <summary>Represents the value 'TK' in the XML</summary>
        [LxEnumValue("TK")]
        TK,
        /// <summary>Represents the value 'TL' in the XML</summary>
        [LxEnumValue("TL")]
        TL,
        /// <summary>Represents the value 'TM' in the XML</summary>
        [LxEnumValue("TM")]
        TM,
        /// <summary>Represents the value 'TN' in the XML</summary>
        [LxEnumValue("TN")]
        TN,
        /// <summary>Represents the value 'TO' in the XML</summary>
        [LxEnumValue("TO")]
        TO_,
        /// <summary>Represents the value 'TR' in the XML</summary>
        [LxEnumValue("TR")]
        TR,
        /// <summary>Represents the value 'TT' in the XML</summary>
        [LxEnumValue("TT")]
        TT,
        /// <summary>Represents the value 'TV' in the XML</summary>
        [LxEnumValue("TV")]
        TV,
        /// <summary>Represents the value 'TW' in the XML</summary>
        [LxEnumValue("TW")]
        TW,
        /// <summary>Represents the value 'TZ' in the XML</summary>
        [LxEnumValue("TZ")]
        TZ,
        /// <summary>Represents the value 'UA' in the XML</summary>
        [LxEnumValue("UA")]
        UA,
        /// <summary>Represents the value 'UG' in the XML</summary>
        [LxEnumValue("UG")]
        UG,
        /// <summary>Represents the value 'UM' in the XML</summary>
        [LxEnumValue("UM")]
        UM,
        /// <summary>Represents the value 'US' in the XML</summary>
        [LxEnumValue("US")]
        US,
        /// <summary>Represents the value 'UY' in the XML</summary>
        [LxEnumValue("UY")]
        UY,
        /// <summary>Represents the value 'UZ' in the XML</summary>
        [LxEnumValue("UZ")]
        UZ,
        /// <summary>Represents the value 'VA' in the XML</summary>
        [LxEnumValue("VA")]
        VA,
        /// <summary>Represents the value 'VC' in the XML</summary>
        [LxEnumValue("VC")]
        VC,
        /// <summary>Represents the value 'VE' in the XML</summary>
        [LxEnumValue("VE")]
        VE,
        /// <summary>Represents the value 'VG' in the XML</summary>
        [LxEnumValue("VG")]
        VG,
        /// <summary>Represents the value 'VI' in the XML</summary>
        [LxEnumValue("VI")]
        VI,
        /// <summary>Represents the value 'VN' in the XML</summary>
        [LxEnumValue("VN")]
        VN,
        /// <summary>Represents the value 'VU' in the XML</summary>
        [LxEnumValue("VU")]
        VU,
        /// <summary>Represents the value 'WF' in the XML</summary>
        [LxEnumValue("WF")]
        WF,
        /// <summary>Represents the value 'WS' in the XML</summary>
        [LxEnumValue("WS")]
        WS,
        /// <summary>Represents the value 'YE' in the XML</summary>
        [LxEnumValue("YE")]
        YE,
        /// <summary>Represents the value 'YT' in the XML</summary>
        [LxEnumValue("YT")]
        YT,
        /// <summary>Represents the value 'ZA' in the XML</summary>
        [LxEnumValue("ZA")]
        ZA,
        /// <summary>Represents the value 'ZM' in the XML</summary>
        [LxEnumValue("ZM")]
        ZM,
        /// <summary>Represents the value 'ZW' in the XML</summary>
        [LxEnumValue("ZW")]
        ZW,
        /// <summary>Represents the value 'BQ' in the XML</summary>
        [LxEnumValue("BQ")]
        BQ,
        /// <summary>Represents the value 'CW' in the XML</summary>
        [LxEnumValue("CW")]
        CW,
        /// <summary>Represents the value 'SS' in the XML</summary>
        [LxEnumValue("SS")]
        SS,
        /// <summary>Represents the value 'SX' in the XML</summary>
        [LxEnumValue("SX")]
        SX,
    }
    /// <summary>An enumeration representing XSD simple type TipoImpuesto@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/simpleType:TipoImpuesto</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>1120:2-1135:18</XsdLocation>
    public enum TipoImpuestoEnum
    {
        /// <summary>Represents the value 'IVA' in the XML</summary>
        [LxEnumValue("IVA")]
        IVA,
        /// <summary>Represents the value 'PETROLEO' in the XML</summary>
        [LxEnumValue("PETROLEO")]
        PETROLEO,
        /// <summary>Represents the value 'TURISMO HOSPEDAJE' in the XML</summary>
        [LxEnumValue("TURISMO HOSPEDAJE")]
        TURISMO_HOSPEDAJE,
        /// <summary>Represents the value 'TURISMO PASAJES' in the XML</summary>
        [LxEnumValue("TURISMO PASAJES")]
        TURISMO_PASAJES,
        /// <summary>Represents the value 'TIMBRE DE PRENSA' in the XML</summary>
        [LxEnumValue("TIMBRE DE PRENSA")]
        TIMBRE_DE_PRENSA,
        /// <summary>Represents the value 'BOMBEROS' in the XML</summary>
        [LxEnumValue("BOMBEROS")]
        BOMBEROS,
        /// <summary>Represents the value 'TASA MUNICIPAL' in the XML</summary>
        [LxEnumValue("TASA MUNICIPAL")]
        TASA_MUNICIPAL,
        /// <summary>Represents the value 'BEBIDAS ALCOHOLICAS' in the XML</summary>
        [LxEnumValue("BEBIDAS ALCOHOLICAS")]
        BEBIDAS_ALCOHOLICAS,
        /// <summary>Represents the value 'TABACO' in the XML</summary>
        [LxEnumValue("TABACO")]
        TABACO,
        /// <summary>Represents the value 'CEMENTO' in the XML</summary>
        [LxEnumValue("CEMENTO")]
        CEMENTO,
        /// <summary>Represents the value 'BEBIDAS NO ALCOHOLICAS' in the XML</summary>
        [LxEnumValue("BEBIDAS NO ALCOHOLICAS")]
        BEBIDAS_NO_ALCOHOLICAS,
        /// <summary>Represents the value 'TARIFA PORTUARIA' in the XML</summary>
        [LxEnumValue("TARIFA PORTUARIA")]
        TARIFA_PORTUARIA,
    }
    /// <summary>An enumeration representing XSD simple type tipoMoneda@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <remarks>ISO 4217</remarks>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/simpleType:tipoMoneda</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>784:2-818:18</XsdLocation>
    public enum TipoMonedaEnum
    {
        /// <summary>Represents the value 'GTQ' in the XML</summary>
        [LxEnumValue("GTQ")]
        GTQ,
        /// <summary>Represents the value 'USD' in the XML</summary>
        [LxEnumValue("USD")]
        USD,
        /// <summary>Represents the value 'VES' in the XML</summary>
        [LxEnumValue("VES")]
        VES,
        /// <summary>Represents the value 'CRC' in the XML</summary>
        [LxEnumValue("CRC")]
        CRC,
        /// <summary>Represents the value 'SVC' in the XML</summary>
        [LxEnumValue("SVC")]
        SVC,
        /// <summary>Represents the value 'NIO' in the XML</summary>
        [LxEnumValue("NIO")]
        NIO,
        /// <summary>Represents the value 'DKK' in the XML</summary>
        [LxEnumValue("DKK")]
        DKK,
        /// <summary>Represents the value 'NOK' in the XML</summary>
        [LxEnumValue("NOK")]
        NOK,
        /// <summary>Represents the value 'SEK' in the XML</summary>
        [LxEnumValue("SEK")]
        SEK,
        /// <summary>Represents the value 'CAD' in the XML</summary>
        [LxEnumValue("CAD")]
        CAD,
        /// <summary>Represents the value 'HKD' in the XML</summary>
        [LxEnumValue("HKD")]
        HKD,
        /// <summary>Represents the value 'TWD' in the XML</summary>
        [LxEnumValue("TWD")]
        TWD,
        /// <summary>Represents the value 'PTE' in the XML</summary>
        [LxEnumValue("PTE")]
        PTE,
        /// <summary>Represents the value 'EUR' in the XML</summary>
        [LxEnumValue("EUR")]
        EUR,
        /// <summary>Represents the value 'CHF' in the XML</summary>
        [LxEnumValue("CHF")]
        CHF,
        /// <summary>Represents the value 'HNL' in the XML</summary>
        [LxEnumValue("HNL")]
        HNL,
        /// <summary>Represents the value 'GBP' in the XML</summary>
        [LxEnumValue("GBP")]
        GBP,
        /// <summary>Represents the value 'ARS' in the XML</summary>
        [LxEnumValue("ARS")]
        ARS,
        /// <summary>Represents the value 'DOP' in the XML</summary>
        [LxEnumValue("DOP")]
        DOP,
        /// <summary>Represents the value 'COP' in the XML</summary>
        [LxEnumValue("COP")]
        COP,
        /// <summary>Represents the value 'MXN' in the XML</summary>
        [LxEnumValue("MXN")]
        MXN,
        /// <summary>Represents the value 'BRL' in the XML</summary>
        [LxEnumValue("BRL")]
        BRL,
        /// <summary>Represents the value 'MYR' in the XML</summary>
        [LxEnumValue("MYR")]
        MYR,
        /// <summary>Represents the value 'INR' in the XML</summary>
        [LxEnumValue("INR")]
        INR,
        /// <summary>Represents the value 'PKR' in the XML</summary>
        [LxEnumValue("PKR")]
        PKR,
        /// <summary>Represents the value 'KPW' in the XML</summary>
        [LxEnumValue("KPW")]
        KPW,
        /// <summary>Represents the value 'JPY' in the XML</summary>
        [LxEnumValue("JPY")]
        JPY,
    }
    #endregion

    #region Complex Types
    /// <summary>A class representing the root XSD complexType tipoDireccion@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/complexType:tipoDireccion</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>731:2-783:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("tipoDireccion", "http://www.sat.gob.gt/dte/fel/0.2.0")]
    public partial class TipoDireccionCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Direccion", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "200", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Direccion { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks></remarks>
        [LxElementValue("CodigoPostal", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger CodigoPostal { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Municipio", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "100", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Municipio { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks></remarks>
        [LxElementValue("Departamento", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MaxLength = "100", WhiteSpace = WhiteSpaceType.Collapse)]
        public System.String Departamento { get; set; } = "";

        /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.TipoCodigoPaisEnum" />, Required</summary>
        /// <remarks></remarks>
        [LxElementValue("Pais", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse)]
        public krudos.FELgt.Documento012.DteA.TipoCodigoPaisEnum Pais { get; set; }

    }

    /// <summary>A class representing the root XSD complexType tipoDocumento@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/complexType:tipoDocumento</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>715:2-715:40</XsdLocation>
    [LxSimpleComplexTypeDefinition("tipoDocumento", "http://www.sat.gob.gt/dte/fel/0.2.0")]
    public partial class TipoDocumentoCt : krudos.FELgt.Documento012.LxBase
    {
    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element GTDocumento@http://www.sat.gob.gt/dte/fel/0.2.0</summary>
    /// <remarks>Definición Global de Documento Electrónico para Guatemala.</remarks>
    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento</XsdPath>
    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
    /// <XsdLocation>6:2-693:15</XsdLocation>
    [LxSimpleElementDefinition("GTDocumento", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.GlobalElement)]
    public partial class GTDocumentoElm : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the attribute Version</summary>
        /// <remarks>Esta casilla indica el numero de versión del documento.</remarks>
        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/attribute:Version</XsdPath>
        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
        /// <XsdLocation>687:4-691:19</XsdLocation>
        [LxAttribute("Version", "", LxValueType.Value, XsdType.XsdDecimal, Required = true)]
        public LiquidTechnologies.XmlObjects.BigDecimal Version { get; set; } = new BigDecimal(new BigInteger(new byte[] {0x01}), -1);

        /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm" />, Required : should not be set to null</summary>
        /// <remarks>Estándar de la Superintendencia de Administración Tributaria para el Documento Tributario Electrónico.</remarks>
        [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm SAT { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignatureTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignatureElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignatureTypeCt" />
        /// </summary>
        [LxElementCt("Signature", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.SignatureTypeCt> Signatures { get; } = new List<krudos.FELgt.Documento012.Ds.SignatureTypeCt>();

        /// <summary>Represent the inline xs:element SAT@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
        /// <remarks>Estándar de la Superintendencia de Administración Tributaria para el Documento Tributario Electrónico.</remarks>
        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT</XsdPath>
        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
        /// <XsdLocation>12:5-683:18</XsdLocation>
        [LxSimpleElementDefinition("SAT", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
        public partial class SATElm : krudos.FELgt.Documento012.LxBase
        {
            /// <summary>The value for the attribute ClaseDocumento</summary>
            /// <remarks>Identificación del Documento Tributario Electrónico.</remarks>
            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/attribute:ClaseDocumento</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
            /// <XsdLocation>671:7-681:22</XsdLocation>
            [LxAttribute("ClaseDocumento", "", LxValueType.Enum, XsdType.Enum, Required = true)]
            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.ClaseDocumentoEnum ClaseDocumento { get; set; }

            /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm" />, Required : should not be set to null</summary>
            /// <remarks>Agrupa la estructura para un DTE. Fecha de inicio de aplicacion: 2019-03-01</remarks>
            [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm DTE { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm();

            /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.AdendaElm" />, Optional : null when not set</summary>
            /// <remarks>Elemento opcional, en el cual se puede indicar información de caracter comercial, no tributaria relacionada con el documento que el emisor le transmite al receptor.</remarks>
            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.AdendaElm Adenda { get; set; }

            /// <summary>An enumeration representing XSD simple type ClaseDocumento</summary>
            /// <remarks>Identificación del Documento Tributario Electrónico.</remarks>
            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/attribute:ClaseDocumento</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
            /// <XsdLocation>671:7-681:22</XsdLocation>
            public enum ClaseDocumentoEnum
            {
                /// <summary>Represents the value 'dte' in the XML</summary>
                [LxEnumValue("dte")]
                Dte,
            }
            /// <summary>Represent the inline xs:element DTE@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
            /// <remarks>Agrupa la estructura para un DTE. Fecha de inicio de aplicacion: 2019-03-01</remarks>
            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
            /// <XsdLocation>18:8-659:21</XsdLocation>
            [LxSimpleElementDefinition("DTE", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
            public partial class DTEElm : krudos.FELgt.Documento012.LxBase
            {
                /// <summary>The value for the attribute ID</summary>
                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/attribute:ID</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                /// <XsdLocation>657:10-657:77</XsdLocation>
                [LxAttribute("ID", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                public System.String ID { get; set; } = "DatosCertificados";

                /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm" />, Required : should not be set to null</summary>
                [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm DatosEmision { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm();

                /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.CertificacionElm" />, Optional : null when not set</summary>
                /// <remarks>Agrupa los datos relacionados con la autorización del DTE de parte del Certificador.</remarks>
                [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.CertificacionElm Certificacion { get; set; }

                /// <summary>Represent the inline xs:element DatosEmision@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                /// <XsdLocation>24:11-576:24</XsdLocation>
                [LxSimpleElementDefinition("DatosEmision", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                public partial class DatosEmisionElm : krudos.FELgt.Documento012.LxBase
                {
                    /// <summary>The value for the attribute ID</summary>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/attribute:ID</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>574:13-574:74</XsdLocation>
                    [LxAttribute("ID", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                    public System.String ID { get; set; } = "DatosEmision";

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa los datos generales del DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm DatosGenerales { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información del Emisor del DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm Emisor { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información del Receptor.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm Receptor { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm" />, Optional : null when not set</summary>
                    /// <remarks>Agrupa las frases de un documento.</remarks>
                    [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm Frases { get; set; }

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa la información de los Items.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm Items { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm" />, Required : should not be set to null</summary>
                    /// <remarks>Agrupa los montos totales a nivel de DTE.</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm Totales { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm();

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm" />, Optional : null when not set</summary>
                    /// <remarks>a) Contiene diferentes subesquemas XSD. b) Sirve para integrar al DTE información adicional de interés para la SAT.</remarks>
                    [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm Complementos { get; set; }

                    /// <summary>Represent the inline xs:element DatosGenerales@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa los datos generales del DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>27:14-99:27</XsdLocation>
                    [LxSimpleElementDefinition("DatosGenerales", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class DatosGeneralesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute Tipo</summary>
                        /// <remarks>Código que indica si el DTE es una factura, una nota de crédito, una nota de débito, un recibo, etc.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Tipo</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>32:16-57:31</XsdLocation>
                        [LxAttribute("Tipo", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm.TipoEnum Tipo { get; set; }

                        /// <summary>The value for the optional attribute Exp</summary>
                        /// <remarks>Indica si el DTE servira para una Exportación</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Exp</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>58:16-67:31</XsdLocation>
                        [LxAttribute("Exp", "", LxValueType.Enum, XsdType.Enum)]
                        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.DatosGeneralesElm.ExpEnum? Exp { get; set; }

                        /// <summary>The value for the attribute FechaHoraEmision</summary>
                        /// <remarks>Fecha y hora de emisión del DTE. Formato aaaa-mm-ddThh:mm:ss.000-06:00 (Milisegundos opcionales, zona horaria especificada o interpretada como hora de Guatemala.)</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:FechaHoraEmision</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>68:16-75:31</XsdLocation>
                        [LxAttribute("FechaHoraEmision", "", LxValueType.Value, XsdType.XsdDateTime, Required = true)]
                        public LiquidTechnologies.XmlObjects.LxDateTime FechaHoraEmision { get; set; }

                        /// <summary>The value for the attribute CodigoMoneda</summary>
                        /// <remarks>Código de la moneda en la que se emite el DTE.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:CodigoMoneda</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>76:16-80:31</XsdLocation>
                        [LxAttribute("CodigoMoneda", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.DteA.TipoMonedaEnum CodigoMoneda { get; set; }

                        /// <summary>The value for the optional attribute NumeroAcceso</summary>
                        /// <remarks>Es un número generado por el Emisor en caso de contingencia, que va desde 100000000 hasta 999999999</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:NumeroAcceso</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>81:16-92:31</XsdLocation>
                        [LxAttribute("NumeroAcceso", "", LxValueType.Value, XsdType.XsdPositiveInteger, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "999999999", MinInclusive = "100000000")]
                        public System.Numerics.BigInteger? NumeroAcceso { get; set; }

                        /// <summary>The value for the optional attribute TipoPersoneria</summary>
                        /// <remarks>Indica el tipo de personeria que esta emitiendo, opcional en esquema pero requerido para personerias que pueden emitir recibos de donacion.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:TipoPersoneria</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>93:16-97:31</XsdLocation>
                        [LxAttribute("TipoPersoneria", "", LxValueType.Value, XsdType.XsdPositiveInteger, WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.Numerics.BigInteger? TipoPersoneria { get; set; }

                        /// <summary>An enumeration representing XSD simple type Tipo</summary>
                        /// <remarks>Código que indica si el DTE es una factura, una nota de crédito, una nota de débito, un recibo, etc.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Tipo</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>32:16-57:31</XsdLocation>
                        public enum TipoEnum
                        {
                            /// <summary>Represents the value 'FACT' in the XML</summary>
                            [LxEnumValue("FACT")]
                            FACT,
                            /// <summary>Represents the value 'FCAM' in the XML</summary>
                            [LxEnumValue("FCAM")]
                            FCAM,
                            /// <summary>Represents the value 'FPEQ' in the XML</summary>
                            [LxEnumValue("FPEQ")]
                            FPEQ,
                            /// <summary>Represents the value 'FCAP' in the XML</summary>
                            [LxEnumValue("FCAP")]
                            FCAP,
                            /// <summary>Represents the value 'FESP' in the XML</summary>
                            [LxEnumValue("FESP")]
                            FESP,
                            /// <summary>Represents the value 'NABN' in the XML</summary>
                            [LxEnumValue("NABN")]
                            NABN,
                            /// <summary>Represents the value 'RDON' in the XML</summary>
                            [LxEnumValue("RDON")]
                            RDON,
                            /// <summary>Represents the value 'RECI' in the XML</summary>
                            [LxEnumValue("RECI")]
                            RECI,
                            /// <summary>Represents the value 'NDEB' in the XML</summary>
                            [LxEnumValue("NDEB")]
                            NDEB,
                            /// <summary>Represents the value 'NCRE' in the XML</summary>
                            [LxEnumValue("NCRE")]
                            NCRE,
                            /// <summary>Represents the value 'FACA' in the XML</summary>
                            [LxEnumValue("FACA")]
                            FACA,
                            /// <summary>Represents the value 'FCCA' in the XML</summary>
                            [LxEnumValue("FCCA")]
                            FCCA,
                            /// <summary>Represents the value 'FAPE' in the XML</summary>
                            [LxEnumValue("FAPE")]
                            FAPE,
                            /// <summary>Represents the value 'FCPE' in the XML</summary>
                            [LxEnumValue("FCPE")]
                            FCPE,
                            /// <summary>Represents the value 'FAAE' in the XML</summary>
                            [LxEnumValue("FAAE")]
                            FAAE,
                            /// <summary>Represents the value 'FCAE' in the XML</summary>
                            [LxEnumValue("FCAE")]
                            FCAE,
                        }
                        /// <summary>An enumeration representing XSD simple type Exp</summary>
                        /// <remarks>Indica si el DTE servira para una Exportación</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:DatosGenerales/attribute:Exp</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>58:16-67:31</XsdLocation>
                        public enum ExpEnum
                        {
                            /// <summary>Represents the value 'SI' in the XML</summary>
                            [LxEnumValue("SI")]
                            SI,
                        }
                    }

                    /// <summary>Represent the inline xs:element Emisor@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa la información del Emisor del DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>100:14-178:27</XsdLocation>
                    [LxSimpleElementDefinition("Emisor", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class EmisorElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute NITEmisor</summary>
                        /// <remarks>Indica el NIT del Emisor del DTE (sin guión).</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NITEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>112:16-116:31</XsdLocation>
                        [LxAttribute("NITEmisor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "13", Pattern = "(([1-9])+([0-9])*([0-9]|K))$", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NITEmisor { get; set; } = "";

                        /// <summary>The value for the attribute NombreEmisor</summary>
                        /// <remarks>Nombres y apellidos o razón social del Emisor (De acuerdo a los registros tributarios en el momento de la emisión).</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NombreEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>117:16-128:31</XsdLocation>
                        [LxAttribute("NombreEmisor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreEmisor { get; set; } = "";

                        /// <summary>The value for the attribute CodigoEstablecimiento</summary>
                        /// <remarks>Número del establecimiento donde se emite el documento. Es el que aparece asignado por SAT en sus registros.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:CodigoEstablecimiento</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>129:16-139:31</XsdLocation>
                        [LxAttribute("CodigoEstablecimiento", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "9999", MinInclusive = "1")]
                        public System.Numerics.BigInteger CodigoEstablecimiento { get; set; }

                        /// <summary>The value for the attribute NombreComercial</summary>
                        /// <remarks>Indica el nombre comercial del establecimiento (de acuerdo a los registros tributarios) donde se emite el documento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:NombreComercial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>140:16-151:31</XsdLocation>
                        [LxAttribute("NombreComercial", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreComercial { get; set; } = "";

                        /// <summary>The value for the optional attribute CorreoEmisor</summary>
                        /// <remarks>Indica la Dirección de correo electrónico del Emisor.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:CorreoEmisor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>152:16-161:31</XsdLocation>
                        [LxAttribute("CorreoEmisor", "", LxValueType.Value, XsdType.XsdString, Pattern = "([a-zA-Z\\-0-9\\.\\_ñ$+=\\!\\#]+@)([a-zA-Zñ\\-0-9\\.\\_]+)[;]*", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String CorreoEmisor { get; set; }

                        /// <summary>The value for the attribute AfiliacionIVA</summary>
                        /// <remarks>De acuerdo al Régimen que tenga registrado el contribuyente, se refiere a que puede ser General, Pequeño Contribuyente, Pequeño Contribuyente Electronico, Agropecuario, Agropecuario Electrónico. (EXE queda por compatibilidad para DTE hasta 29/feb/2020)</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:AfiliacionIVA</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>162:16-176:31</XsdLocation>
                        [LxAttribute("AfiliacionIVA", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.EmisorElm.AfiliacionIVAEnum AfiliacionIVA { get; set; }

                        /// <summary>
                        ///   A class derived from <see cref="krudos.FELgt.Documento012.DteA.TipoDireccionCt" />.<br/><br/>
                        ///   Allowable types are <br/>
                        ///       <see cref="krudos.FELgt.Documento012.DteA.TipoDireccionCt" />
                        /// </summary>
                        /// <remarks>Agrupa los datos de la dirección del establecimiento del Emisor.</remarks>
                        [LxElementCt("DireccionEmisor", "http://www.sat.gob.gt/dte/fel/0.2.0", MinOccurs = 1, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.DteA.TipoDireccionCt DireccionEmisor { get; set; } = new krudos.FELgt.Documento012.DteA.TipoDireccionCt();

                        /// <summary>An enumeration representing XSD simple type AfiliacionIVA</summary>
                        /// <remarks>De acuerdo al Régimen que tenga registrado el contribuyente, se refiere a que puede ser General, Pequeño Contribuyente, Pequeño Contribuyente Electronico, Agropecuario, Agropecuario Electrónico. (EXE queda por compatibilidad para DTE hasta 29/feb/2020)</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Emisor/attribute:AfiliacionIVA</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>162:16-176:31</XsdLocation>
                        public enum AfiliacionIVAEnum
                        {
                            /// <summary>Represents the value 'GEN' in the XML</summary>
                            [LxEnumValue("GEN")]
                            GEN,
                            /// <summary>Represents the value 'EXE' in the XML</summary>
                            [LxEnumValue("EXE")]
                            EXE,
                            /// <summary>Represents the value 'PEQ' in the XML</summary>
                            [LxEnumValue("PEQ")]
                            PEQ,
                            /// <summary>Represents the value 'PEE' in the XML</summary>
                            [LxEnumValue("PEE")]
                            PEE,
                            /// <summary>Represents the value 'AGR' in the XML</summary>
                            [LxEnumValue("AGR")]
                            AGR,
                            /// <summary>Represents the value 'AGE' in the XML</summary>
                            [LxEnumValue("AGE")]
                            AGE,
                        }
                    }

                    /// <summary>Represent the inline xs:element Receptor@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa la información del Receptor.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>179:14-236:27</XsdLocation>
                    [LxSimpleElementDefinition("Receptor", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class ReceptorElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute IDReceptor</summary>
                        /// <remarks>Indica el NIT o CUI del RECEPTOR, CF.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:IDReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>191:16-200:31</XsdLocation>
                        [LxAttribute("IDReceptor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "18", Pattern = "((([1-9])+([0-9])*([0-9]|K))|(([1-9]+[0-9]){12,13})|(CF)|^([A-Z0-9]{3,18}))$", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String IDReceptor { get; set; } = "";

                        /// <summary>The value for the optional attribute TipoEspecial</summary>
                        /// <remarks>Cuando la casilla está llena debe contener el valor “CUI”, lo que significa que la casilla “IDReceptor” no incluye un NIT sino un CUI.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:TipoEspecial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>201:16-212:31</XsdLocation>
                        [LxAttribute("TipoEspecial", "", LxValueType.Enum, XsdType.Enum)]
                        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ReceptorElm.TipoEspecialEnum? TipoEspecial { get; set; }

                        /// <summary>The value for the attribute NombreReceptor</summary>
                        /// <remarks>Si la casilla “IDReceptor” contiene un NIT valido el nombre indicado debe corresponder a los registros tributarios. Caso contrario el contenido puede ser cualquiera que solicite el RECEPTOR.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:NombreReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>213:16-224:31</XsdLocation>
                        [LxAttribute("NombreReceptor", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String NombreReceptor { get; set; } = "";

                        /// <summary>The value for the optional attribute CorreoReceptor</summary>
                        /// <remarks>Indica la Dirección de correo electrónico del receptor.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:CorreoReceptor</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>225:16-234:31</XsdLocation>
                        [LxAttribute("CorreoReceptor", "", LxValueType.Value, XsdType.XsdString, Pattern = "([a-zA-Z\\-0-9\\.\\_ñ$+=\\!\\#]+@)([a-zA-Zñ\\-0-9\\.\\_]+)[;]*", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String CorreoReceptor { get; set; }

                        /// <summary>
                        ///   A class derived from <see cref="krudos.FELgt.Documento012.DteA.TipoDireccionCt" />.<br/><br/>
                        ///   Allowable types are <br/>
                        ///       <see cref="krudos.FELgt.Documento012.DteA.TipoDireccionCt" />
                        /// </summary>
                        /// <remarks>Agrupa los datos de dirección del receptor.</remarks>
                        [LxElementCt("DireccionReceptor", "http://www.sat.gob.gt/dte/fel/0.2.0", MinOccurs = 0, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.DteA.TipoDireccionCt DireccionReceptor { get; set; }

                        /// <summary>An enumeration representing XSD simple type TipoEspecial</summary>
                        /// <remarks>Cuando la casilla está llena debe contener el valor “CUI”, lo que significa que la casilla “IDReceptor” no incluye un NIT sino un CUI.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Receptor/attribute:TipoEspecial</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>201:16-212:31</XsdLocation>
                        public enum TipoEspecialEnum
                        {
                            /// <summary>Represents the value 'CUI' in the XML</summary>
                            [LxEnumValue("CUI")]
                            CUI,
                            /// <summary>Represents the value 'EXT' in the XML</summary>
                            [LxEnumValue("EXT")]
                            EXT,
                        }
                    }

                    /// <summary>Represent the inline xs:element Frases@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa las frases de un documento.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>237:14-301:27</XsdLocation>
                    [LxSimpleElementDefinition("Frases", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class FrasesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm" /></summary>
                        /// <remarks>En esta sección deberá indicarse los regímenes y textos especiales que son requeridos en los DTE, de acuerdo a la afiliación del contribuyente y tipo de operación.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm> Frases { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.FrasesElm.FraseElm>();

                        /// <summary>Represent the inline xs:element Frase@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                        /// <remarks>En esta sección deberá indicarse los regímenes y textos especiales que son requeridos en los DTE, de acuerdo a la afiliación del contribuyente y tipo de operación.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>243:17-298:30</XsdLocation>
                        [LxSimpleElementDefinition("Frase", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                        public partial class FraseElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the attribute TipoFrase</summary>
                            /// <remarks>Identifica un determinado catálogo de leyendas.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:TipoFrase</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>248:19-262:34</XsdLocation>
                            [LxAttribute("TipoFrase", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, WhiteSpace = WhiteSpaceType.Collapse, MaxInclusive = "7", MinInclusive = "1")]
                            public System.Numerics.BigInteger TipoFrase { get; set; }

                            /// <summary>The value for the attribute CodigoEscenario</summary>
                            /// <remarks>Indica un determinado Escenario dentro del catálogo de leyendas.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:CodigoEscenario</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>263:19-273:34</XsdLocation>
                            [LxAttribute("CodigoEscenario", "", LxValueType.Value, XsdType.XsdInt, Required = true, MaxInclusive = "99", MinInclusive = "1")]
                            public System.Int32 CodigoEscenario { get; set; }

                            /// <summary>The value for the optional attribute NumeroResolucion</summary>
                            /// <remarks>Numero de resolución relacionada a la frase.. Uso opcional de acuerdo a reglas y validaciones.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:NumeroResolucion</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>274:19-285:34</XsdLocation>
                            [LxAttribute("NumeroResolucion", "", LxValueType.Value, XsdType.XsdString, MinLength = "4", MaxLength = "50", WhiteSpace = WhiteSpaceType.Collapse)]
                            public System.String NumeroResolucion { get; set; }

                            /// <summary>The value for the optional attribute FechaResolucion</summary>
                            /// <remarks>Fecha de resolución relacionada a la frase. Uso opcional de acuerdo a reglas y validaciones.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Frases/sequence/element:Frase/attribute:FechaResolucion</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>286:19-295:34</XsdLocation>
                            [LxAttribute("FechaResolucion", "", LxValueType.Value, XsdType.XsdDate, Pattern = "((\\d{4})-(\\d{2})-(\\d{2}))")]
                            public LiquidTechnologies.XmlObjects.LxDateTime? FechaResolucion { get; set; }

                        }

                    }

                    /// <summary>Represent the inline xs:element Items@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa la información de los Items.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>302:14-493:27</XsdLocation>
                    [LxSimpleElementDefinition("Items", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class ItemsElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm" /></summary>
                        /// <remarks>Agrupa la información de un renglón o ítem de un DTE. Se refiere a lo que la Ley del IVA define como “concepto” en la venta de bienes o como “clase de servicio” en la prestación de servicios. También se refiere a lo que el Reglamento de la Ley del IVA indica como “detalle” o “descripción” de la venta, del servicio prestado o del arrendamiento.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm> Items { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm>();

                        /// <summary>Represent the inline xs:element Item@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                        /// <remarks>Agrupa la información de un renglón o ítem de un DTE. Se refiere a lo que la Ley del IVA define como “concepto” en la venta de bienes o como “clase de servicio” en la prestación de servicios. También se refiere a lo que el Reglamento de la Ley del IVA indica como “detalle” o “descripción” de la venta, del servicio prestado o del arrendamiento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>308:17-490:30</XsdLocation>
                        [LxSimpleElementDefinition("Item", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                        public partial class ItemElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the attribute NumeroLinea</summary>
                            /// <remarks>Correlativo del ítem dentro del DTE. En el caso de Notas de Débito y Notas de Crédito identifica el renglón o ítem del documento original.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:NumeroLinea</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>465:19-475:34</XsdLocation>
                            [LxAttribute("NumeroLinea", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "9999", MinInclusive = "1")]
                            public System.Numerics.BigInteger NumeroLinea { get; set; }

                            /// <summary>The value for the attribute BienOServicio</summary>
                            /// <remarks>Indica si el ítem es un bien o servicio.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:BienOServicio</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>476:19-488:34</XsdLocation>
                            [LxAttribute("BienOServicio", "", LxValueType.Enum, XsdType.Enum, Required = true)]
                            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.BienOServicioEnum BienOServicio { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Indica la cantidad de unidades del ítem.</remarks>
                            [LxElementValue("Cantidad", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Cantidad { get; set; }

                            /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
                            /// <remarks>Indica la unidad de medida en que está expresado el elemento CantidadItem. Si el emisor lo desea, puede utilizar la nomenclatura definida por la Intendencia de Aduanas de la SAT en su tabla SAT-IA-008.</remarks>
                            [LxElementValue("UnidadMedida", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3", WhiteSpace = WhiteSpaceType.Collapse)]
                            public System.String UnidadMedida { get; set; }

                            /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                            /// <remarks>Indica la descripción del ítem.</remarks>
                            [LxElementValue("Descripcion", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "10000", WhiteSpace = WhiteSpaceType.Collapse)]
                            public System.String Descripcion { get; set; } = "";

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Precio de cada unidad del ítem en la moneda en que se emite el DTE (quetzales, dólares, euros, etc.).</remarks>
                            [LxElementValue("PrecioUnitario", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                            public LiquidTechnologies.XmlObjects.BigDecimal PrecioUnitario { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>PrecioUnitario multiplicado por CantidadItem.</remarks>
                            [LxElementValue("Precio", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Precio { get; set; }

                            /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                            /// <remarks>Indica el descuento a aplicar sobre el elemento Precio.</remarks>
                            [LxElementValue("Descuento", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                            public LiquidTechnologies.XmlObjects.BigDecimal? Descuento { get; set; }

                            /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm" />, Optional : null when not set</summary>
                            /// <remarks>Agrupa los impuestos aplicados al ítem.</remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm Impuestos { get; set; }

                            /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                            /// <remarks>Precio menos Descuento más la sumatoria de las casillas “MontoImpuesto” (de los impuestos que sean sumables al DTE.</remarks>
                            [LxElementValue("Total", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                            public LiquidTechnologies.XmlObjects.BigDecimal Total { get; set; }

                            /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm" />, Optional : null when not set</summary>
                            /// <remarks>a) Contiene diferentes subesquemas XSD. b) Sirve para integrar al ítem información adicional de interés para la SAT.</remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                            public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm ComplementosItem { get; set; }

                            /// <summary>An enumeration representing XSD simple type BienOServicio</summary>
                            /// <remarks>Indica si el ítem es un bien o servicio.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/attribute:BienOServicio</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>476:19-488:34</XsdLocation>
                            public enum BienOServicioEnum
                            {
                                /// <summary>Represents the value 'B' in the XML</summary>
                                [LxEnumValue("B")]
                                B,
                                /// <summary>Represents the value 'S' in the XML</summary>
                                [LxEnumValue("S")]
                                S,
                            }
                            /// <summary>Represent the inline xs:element Impuestos@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                            /// <remarks>Agrupa los impuestos aplicados al ítem.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:Impuestos</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>366:20-424:33</XsdLocation>
                            [LxSimpleElementDefinition("Impuestos", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                            public partial class ImpuestosElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm" /></summary>
                                /// <remarks>Agrupa los datos de un Impuesto.</remarks>
                                [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                                public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm> Impuestos { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ImpuestosElm.ImpuestoElm>();

                                /// <summary>Represent the inline xs:element Impuesto@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                                /// <remarks>Agrupa los datos de un Impuesto.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:Impuestos/sequence/element:Impuesto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                /// <XsdLocation>372:23-421:36</XsdLocation>
                                [LxSimpleElementDefinition("Impuesto", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                                public partial class ImpuestoElm : krudos.FELgt.Documento012.LxBase
                                {
                                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.TipoImpuestoEnum" />, Required</summary>
                                    /// <remarks>Nombre corto que identifica el impuesto.</remarks>
                                    [LxElementValue("NombreCorto", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.Enum, MinOccurs = 1, MaxOccurs = 1, WhiteSpace = WhiteSpaceType.Collapse)]
                                    public krudos.FELgt.Documento012.DteA.TipoImpuestoEnum NombreCorto { get; set; }

                                    /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("CodigoUnidadGravable", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "7")]
                                    public System.Numerics.BigInteger CodigoUnidadGravable { get; set; }

                                    /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                                    /// <remarks>Monto sobre el cual se aplica el impuesto.</remarks>
                                    [LxElementValue("MontoGravable", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal? MontoGravable { get; set; }

                                    /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("CantidadUnidadesGravables", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal? CantidadUnidadesGravables { get; set; }

                                    /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                                    /// <remarks></remarks>
                                    [LxElementValue("MontoImpuesto", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                                    public LiquidTechnologies.XmlObjects.BigDecimal MontoImpuesto { get; set; }

                                }

                            }

                            /// <summary>Represent the inline xs:element ComplementosItem@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                            /// <remarks>a) Contiene diferentes subesquemas XSD. b) Sirve para integrar al ítem información adicional de interés para la SAT.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>430:20-463:33</XsdLocation>
                            [LxSimpleElementDefinition("ComplementosItem", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                            public partial class ComplementosItemElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm" /></summary>
                                /// <remarks>Complemento Item.</remarks>
                                [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                                public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm> ComplementoItems { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ItemsElm.ItemElm.ComplementosItemElm.ComplementoItemElm>();

                                /// <summary>Represent the inline xs:element ComplementoItem@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                                /// <remarks>Complemento Item.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                /// <XsdLocation>436:23-460:36</XsdLocation>
                                [LxSimpleElementDefinition("ComplementoItem", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                                public partial class ComplementoItemElm : krudos.FELgt.Documento012.LxBase
                                {
                                    /// <summary>The value for the optional attribute IDComplementoItem</summary>
                                    /// <remarks>Identificador del complemento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:IDComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                    /// <XsdLocation>444:25-448:40</XsdLocation>
                                    [LxAttribute("IDComplementoItem", "", LxValueType.Value, XsdType.XsdString)]
                                    public System.String IDComplementoItem { get; set; }

                                    /// <summary>The value for the attribute NombreComplementoItem</summary>
                                    /// <remarks>Indica el nombre del complento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:NombreComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                    /// <XsdLocation>449:25-453:40</XsdLocation>
                                    [LxAttribute("NombreComplementoItem", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                                    public System.String NombreComplementoItem { get; set; } = "";

                                    /// <summary>The value for the attribute URIComplementoItem</summary>
                                    /// <remarks>Indica el URI del XSD del complemento del Item.</remarks>
                                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/attribute:URIComplementoItem</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                    /// <XsdLocation>454:25-458:40</XsdLocation>
                                    [LxAttribute("URIComplementoItem", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                                    public System.String URIComplementoItem { get; set; } = "";

                                    /// <summary>An <see cref="XElement"/> to hold the additional element described by an xs:any, Required : should be set before calling Serialize.</summary>
                                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Items/sequence/element:Item/sequence/element:ComplementosItem/sequence/element:ComplementoItem/sequence/any</XsdPath>
                                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                    /// <XsdLocation>442:26-442:35</XsdLocation>
                                    [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.2.0", MinOccurs = 1, MaxOccurs = 1)]
                                    public XElement AnyElement { get; set; }

                                }

                            }

                        }

                    }

                    /// <summary>Represent the inline xs:element Totales@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Agrupa los montos totales a nivel de DTE.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>494:14-538:27</XsdLocation>
                    [LxSimpleElementDefinition("Totales", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class TotalesElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm" />, Optional : null when not set</summary>
                        /// <remarks>Agrupa los totales de impuestos agrupados por tipo de impuesto.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = 1)]
                        public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm TotalImpuestos { get; set; }

                        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
                        /// <remarks>Sumatoria de los elementos Total de cada uno de los ítems del DTE.</remarks>
                        [LxElementValue("GranTotal", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                        public LiquidTechnologies.XmlObjects.BigDecimal GranTotal { get; set; }

                        /// <summary>Represent the inline xs:element TotalImpuestos@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                        /// <remarks>Agrupa los totales de impuestos agrupados por tipo de impuesto.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>500:17-530:30</XsdLocation>
                        [LxSimpleElementDefinition("TotalImpuestos", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                        public partial class TotalImpuestosElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm" /></summary>
                            /// <remarks>Agrupa los datos de cada impuesto.</remarks>
                            [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                            public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm> TotalImpuestos { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.TotalesElm.TotalImpuestosElm.TotalImpuestoElm>();

                            /// <summary>Represent the inline xs:element TotalImpuesto@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                            /// <remarks>Agrupa los datos de cada impuesto.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>506:20-527:33</XsdLocation>
                            [LxSimpleElementDefinition("TotalImpuesto", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                            public partial class TotalImpuestoElm : krudos.FELgt.Documento012.LxBase
                            {
                                /// <summary>The value for the attribute NombreCorto</summary>
                                /// <remarks>Nombre corto que identifica el impuesto.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto/attribute:NombreCorto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                /// <XsdLocation>511:22-520:37</XsdLocation>
                                [LxAttribute("NombreCorto", "", LxValueType.Value, XsdType.Enum, Required = true, WhiteSpace = WhiteSpaceType.Collapse)]
                                public krudos.FELgt.Documento012.DteA.TipoImpuestoEnum NombreCorto { get; set; }

                                /// <summary>The value for the attribute TotalMontoImpuesto</summary>
                                /// <remarks>Sumatoria de MontoImpuesto de cada uno de los ítems con el mismo impuesto. Ejemplo: Si el elemento impuesto es IVA, este atributo deberá contener la sumatoria de los montos de IVA incluidos en todos los ítems del documento.</remarks>
                                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Totales/sequence/element:TotalImpuestos/sequence/element:TotalImpuesto/attribute:TotalMontoImpuesto</XsdPath>
                                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                                /// <XsdLocation>521:22-525:37</XsdLocation>
                                [LxAttribute("TotalMontoImpuesto", "", LxValueType.Value, XsdType.XsdDecimal, Required = true, MinInclusive = "0", TotalDigits = "22", FractionDigits = "10")]
                                public LiquidTechnologies.XmlObjects.BigDecimal TotalMontoImpuesto { get; set; }

                            }

                        }

                    }

                    /// <summary>Represent the inline xs:element Complementos@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>a) Contiene diferentes subesquemas XSD. b) Sirve para integrar al DTE información adicional de interés para la SAT.</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>539:14-572:27</XsdLocation>
                    [LxSimpleElementDefinition("Complementos", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class ComplementosElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>A collection of <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm" /></summary>
                        /// <remarks>Complemento.</remarks>
                        [LxElementRef(MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                        public List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm> Complementos { get; } = new List<krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.DatosEmisionElm.ComplementosElm.ComplementoElm>();

                        /// <summary>Represent the inline xs:element Complemento@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                        /// <remarks>Complemento.</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>545:17-569:30</XsdLocation>
                        [LxSimpleElementDefinition("Complemento", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                        public partial class ComplementoElm : krudos.FELgt.Documento012.LxBase
                        {
                            /// <summary>The value for the optional attribute IDComplemento</summary>
                            /// <remarks>Identificador del complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:IDComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>553:19-557:34</XsdLocation>
                            [LxAttribute("IDComplemento", "", LxValueType.Value, XsdType.XsdString)]
                            public System.String IDComplemento { get; set; }

                            /// <summary>The value for the attribute NombreComplemento</summary>
                            /// <remarks>Indica el nombre del Complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:NombreComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>558:19-562:34</XsdLocation>
                            [LxAttribute("NombreComplemento", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                            public System.String NombreComplemento { get; set; } = "";

                            /// <summary>The value for the attribute URIComplemento</summary>
                            /// <remarks>Indica el URI del XSD del complemento.</remarks>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/attribute:URIComplemento</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>563:19-567:34</XsdLocation>
                            [LxAttribute("URIComplemento", "", LxValueType.Value, XsdType.XsdString, Required = true)]
                            public System.String URIComplemento { get; set; } = "";

                            /// <summary>An <see cref="XElement"/> to hold the additional element described by an xs:any, Required : should be set before calling Serialize.</summary>
                            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:DatosEmision/sequence/element:Complementos/sequence/element:Complemento/sequence/any</XsdPath>
                            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                            /// <XsdLocation>551:20-551:29</XsdLocation>
                            [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.2.0", MinOccurs = 1, MaxOccurs = 1)]
                            public XElement AnyElement { get; set; }

                        }

                    }

                }

                /// <summary>Represent the inline xs:element Certificacion@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                /// <remarks>Agrupa los datos relacionados con la autorización del DTE de parte del Certificador.</remarks>
                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                /// <XsdLocation>577:11-655:24</XsdLocation>
                [LxSimpleElementDefinition("Certificacion", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                public partial class CertificacionElm : krudos.FELgt.Documento012.LxBase
                {
                    /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                    /// <remarks>NIT del Certificador sin guión.</remarks>
                    [LxElementValue("NITCertificador", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "13", Pattern = "([1-9])+([0-9])*([0-9]|K)", WhiteSpace = WhiteSpaceType.Collapse)]
                    public System.String NITCertificador { get; set; } = "";

                    /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
                    /// <remarks>Nombre del Certificador (De acuerdo a los registros tributarios).</remarks>
                    [LxElementValue("NombreCertificador", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "255", WhiteSpace = WhiteSpaceType.Collapse)]
                    public System.String NombreCertificador { get; set; } = "";

                    /// <summary>A <see cref="krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm" />, Required : should not be set to null</summary>
                    /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                    [LxElementRef(MinOccurs = 1, MaxOccurs = 1)]
                    public krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm NumeroAutorizacion { get; set; } = new krudos.FELgt.Documento012.DteA.GTDocumentoElm.SATElm.DTEElm.CertificacionElm.NumeroAutorizacionElm();

                    /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
                    /// <remarks>Es la fecha y hora del momento en que el Certificador incorpora su firma electrónica al DTE. Formato aaaa-mm-ddThh:mm:ss.000-06:00 (Milisegundos opcionales, zona horaria especificada o interpretada como hora de Guatemala</remarks>
                    [LxElementValue("FechaHoraCertificacion", "http://www.sat.gob.gt/dte/fel/0.2.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 1, MaxOccurs = 1, Pattern = "((\\d{4})-(\\d{2})-(\\d{2})T(\\d{2}):(\\d{2}):(\\d{2})(.(\\d{3}))?(-06:00)?)")]
                    public LiquidTechnologies.XmlObjects.LxDateTime FechaHoraCertificacion { get; set; }

                    /// <summary>Represent the inline xs:element NumeroAutorizacion@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
                    /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                    /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion</XsdPath>
                    /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                    /// <XsdLocation>608:14-642:27</XsdLocation>
                    [LxSimpleElementDefinition("NumeroAutorizacion", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
                    public partial class NumeroAutorizacionElm : krudos.FELgt.Documento012.LxBase
                    {
                        /// <summary>The value for the attribute Serie</summary>
                        /// <remarks>Se forma con los primeros 8 dígitos hexadecimales del UUID, de izquierda a derecha, de tal forma que queda estructurado como se describe a continuación: De un UUID Original: dbb51ae2-3a62-4437-b8e9-42ecfb761156, el valor resultante será: dbb51ae2</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion/attribute:Serie</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>615:18-626:33</XsdLocation>
                        [LxAttribute("Serie", "", LxValueType.Value, XsdType.XsdString, Required = true, MinLength = "1", MaxLength = "20", WhiteSpace = WhiteSpaceType.Collapse)]
                        public System.String Serie { get; set; } = "";

                        /// <summary>The value for the attribute Numero</summary>
                        /// <remarks>Se forma con el equivalente en números decimales de los dígitos hexadecimales del UUID, a partir de la posición 9 hasta la posición 16 (excluyendo los guiones “-“), de izquierda a derecha, de tal forma que queda estructurado como se describe a continuación: De un UUID Original: dbb51ae2-3a62-4437-b8e9-42ecfb761156, el valor resultante será: 979518519</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion/attribute:Numero</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>627:18-638:33</XsdLocation>
                        [LxAttribute("Numero", "", LxValueType.Value, XsdType.XsdPositiveInteger, Required = true, MaxInclusive = "999999999999999", MinInclusive = "1", TotalDigits = "15")]
                        public System.Numerics.BigInteger Numero { get; set; }

                        /// <summary>Holds the <see cref="System.String" /> value of the element</summary>
                        /// <remarks>Número de autorización asignado que identifica de forma única a cada documento emitido por medio del sistema del Certificador. Por la naturaleza del UUID no es un número correlativo y se representa como un número hexadecimal</remarks>
                        /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:DTE/sequence/element:Certificacion/sequence/element:NumeroAutorizacion</XsdPath>
                        /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                        /// <XsdLocation>608:14-642:27</XsdLocation>
                        [LxValue(LxValueType.Value, XsdType.XsdToken, Pattern = "[0-9A-F]{8}-([0-9A-F]{4}-){3}[0-9A-F]{12}")]
                        public System.String Value { get; set; } = "";

                    }

                }

            }

            /// <summary>Represent the inline xs:element Adenda@http://www.sat.gob.gt/dte/fel/0.2.0.</summary>
            /// <remarks>Elemento opcional, en el cual se puede indicar información de caracter comercial, no tributaria relacionada con el documento que el emisor le transmite al receptor.</remarks>
            /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:Adenda</XsdPath>
            /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
            /// <XsdLocation>660:8-669:21</XsdLocation>
            [LxSimpleElementDefinition("Adenda", "http://www.sat.gob.gt/dte/fel/0.2.0", ElementScopeType.InlineElement)]
            public partial class AdendaElm : krudos.FELgt.Documento012.LxBase
            {
                /// <summary>A collection of <see cref="XElement"/>'s to hold the additional elements described by an xs:any</summary>
                /// <XsdPath>schema:GT_Documento-0.2.1.xsd/element:GTDocumento/sequence/element:SAT/sequence/element:Adenda/sequence/any</XsdPath>
                /// <XsdFile>C:\dev\xsd\GT_Documento-0.2.1.xsd</XsdFile>
                /// <XsdLocation>666:11-666:82</XsdLocation>
                [LxElementAny(TargetNamespaceUri = "http://www.sat.gob.gt/dte/fel/0.2.0", Namespaces = new string[] { "##any"}, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
                public List<XElement> AnyElements { get; } = new List<XElement>();

            }

        }

    }

    #endregion

}

namespace krudos.FELgt.Documento012.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace krudos.FELgt.Documento012.Ds
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType CanonicalizationMethodType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:CanonicalizationMethodType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>76:3-82:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("CanonicalizationMethodType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class CanonicalizationMethodTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType DigestMethodType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:DigestMethodType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>128:1-133:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("DigestMethodType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class DigestMethodTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType DSAKeyValueType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:DSAKeyValueType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>290:1-304:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("DSAKeyValueType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class DSAKeyValueTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("P", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] P { get; set; }

        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("Q", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] Q { get; set; }

        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("G", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] G { get; set; }

        /// <summary>A <see cref="System.Byte" />[], Required : should not be set to null</summary>
        [LxElementValue("Y", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 1, MaxOccurs = 1)]
        public System.Byte[] Y { get; set; } = new byte[0];

        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("J", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] J { get; set; }

        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("Seed", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] Seed { get; set; }

        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("PgenCounter", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] PgenCounter { get; set; }

    }

    /// <summary>A class representing the root XSD complexType KeyInfoType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:KeyInfoType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>145:1-158:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("KeyInfoType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType KeyValueType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:KeyValueType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>164:3-170:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("KeyValueType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyValueTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType ManifestType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ManifestType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>254:1-259:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("ManifestType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ManifestTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ManifestType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>258:3-258:50</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.ReferenceTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.ReferenceElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.ReferenceTypeCt" />
        /// </summary>
        [LxElementCt("Reference", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.ReferenceTypeCt> References { get; } = new List<krudos.FELgt.Documento012.Ds.ReferenceTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ObjectType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ObjectType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>244:1-251:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("ObjectType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ObjectTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType PGPDataType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:PGPDataType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>209:1-223:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("PGPDataType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class PGPDataTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.Byte" />[], Optional : null when not set</summary>
        [LxElementValue("PGPKeyID", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = 1)]
        public System.Byte[] PGPKeyID { get; set; }

        /// <summary>A collection of <see cref="System.Byte" />[]</summary>
        [LxElementValue("PGPKeyPacket", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Byte[]> PGPKeyPackets { get; } = new List<System.Byte[]>();

        /// <summary>A collection of <see cref="XElement"/>'s to hold the additional elements described by an xs:any</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:PGPDataType/choice/sequence/any</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>214:7-215:31</XsdLocation>
        [LxElementAny(TargetNamespaceUri = "http://www.w3.org/2000/09/xmldsig#", Namespaces = new string[] { "##other"}, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<XElement> AnyElements { get; } = new List<XElement>();

    }

    /// <summary>A class representing the root XSD complexType ReferenceType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ReferenceType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>97:1-106:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("ReferenceType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ReferenceType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>103:3-103:50</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>The value for the optional attribute URI</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ReferenceType/attribute:URI</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>104:3-104:55</XsdLocation>
        [LxAttribute("URI", "", LxValueType.Value, XsdType.XsdAnyURI)]
        public System.String URI { get; set; }

        /// <summary>The value for the optional attribute Type</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:ReferenceType/attribute:Type</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>105:3-105:56</XsdLocation>
        [LxAttribute("Type", "", LxValueType.Value, XsdType.XsdAnyURI)]
        public System.String Type { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.TransformsTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.TransformsElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.TransformsTypeCt" />
        /// </summary>
        [LxElementCt("Transforms", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.TransformsTypeCt Transforms { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.DigestMethodTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.DigestMethodElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.DigestMethodTypeCt" />
        /// </summary>
        [LxElementCt("DigestMethod", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.DigestMethodTypeCt DigestMethod { get; set; } = new krudos.FELgt.Documento012.Ds.DigestMethodElm();

        /// <summary>A <see cref="System.Byte" />[], Required : should not be set to null</summary>
        [LxElementValue("DigestValue", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 1, MaxOccurs = 1)]
        public System.Byte[] DigestValue { get; set; } = new byte[0];

    }

    /// <summary>A class representing the root XSD complexType RetrievalMethodType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:RetrievalMethodType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>173:3-179:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("RetrievalMethodType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class RetrievalMethodTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute URI</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:RetrievalMethodType/attribute:URI</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>177:5-177:42</XsdLocation>
        [LxAttribute("URI", "", LxValueType.Value, XsdType.XsdAnyURI)]
        public System.String URI { get; set; }

        /// <summary>The value for the optional attribute Type</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:RetrievalMethodType/attribute:Type</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>178:5-178:58</XsdLocation>
        [LxAttribute("Type", "", LxValueType.Value, XsdType.XsdAnyURI)]
        public System.String Type { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.TransformsTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.TransformsElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.TransformsTypeCt" />
        /// </summary>
        [LxElementCt("Transforms", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.TransformsTypeCt Transforms { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RSAKeyValueType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:RSAKeyValueType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>307:1-312:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("RSAKeyValueType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class RSAKeyValueTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.Byte" />[], Required : should not be set to null</summary>
        [LxElementValue("Modulus", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 1, MaxOccurs = 1)]
        public System.Byte[] Modulus { get; set; } = new byte[0];

        /// <summary>A <see cref="System.Byte" />[], Required : should not be set to null</summary>
        [LxElementValue("Exponent", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 1, MaxOccurs = 1)]
        public System.Byte[] Exponent { get; set; } = new byte[0];

    }

    /// <summary>A class representing the root XSD complexType SignatureMethodType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureMethodType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>85:3-92:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatureMethodType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureMethodTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType SignaturePropertiesType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignaturePropertiesType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>262:1-267:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignaturePropertiesType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignaturePropertiesTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignaturePropertiesType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>266:3-266:50</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignaturePropertyTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignaturePropertyElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignaturePropertyTypeCt" />
        /// </summary>
        [LxElementCt("SignatureProperty", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.SignaturePropertyTypeCt> SignatureProperties { get; } = new List<krudos.FELgt.Documento012.Ds.SignaturePropertyTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType SignaturePropertyType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignaturePropertyType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>270:4-277:18</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignaturePropertyType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignaturePropertyTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType SignatureType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>44:1-52:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatureType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>51:3-51:50</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignedInfoTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignedInfoElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignedInfoTypeCt" />
        /// </summary>
        [LxElementCt("SignedInfo", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.SignedInfoTypeCt SignedInfo { get; set; } = new krudos.FELgt.Documento012.Ds.SignedInfoElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignatureValueTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignatureValueElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignatureValueTypeCt" />
        /// </summary>
        [LxElementCt("SignatureValue", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.SignatureValueTypeCt SignatureValue { get; set; } = new krudos.FELgt.Documento012.Ds.SignatureValueElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.KeyInfoTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.KeyInfoElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.KeyInfoTypeCt" />
        /// </summary>
        [LxElementCt("KeyInfo", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.KeyInfoTypeCt KeyInfo { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.ObjectTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.Object_Elm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.ObjectTypeCt" />
        /// </summary>
        [LxElementCt("Object", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.ObjectTypeCt> Objects { get; } = new List<krudos.FELgt.Documento012.Ds.ObjectTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType SignatureValueType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureValueType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>55:3-61:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatureValueType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureValueType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>58:9-58:56</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>Holds the <see cref="System.Byte" />[] (xs:http://www.w3.org/2001/XMLSchema:base64Binary) value of the element</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignatureValueType</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>55:3-61:17</XsdLocation>
        [LxValue(LxValueType.Value, XsdType.XsdBase64Binary)]
        public System.Byte[] Value { get; set; } = new byte[0];

    }

    /// <summary>A class representing the root XSD complexType SignedInfoType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignedInfoType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>66:1-73:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignedInfoType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>The value for the optional attribute Id</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SignedInfoType/attribute:Id</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>72:3-72:50</XsdLocation>
        [LxAttribute("Id", "", LxValueType.Value, XsdType.XsdID)]
        public System.String Id { get; set; }

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.CanonicalizationMethodTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.CanonicalizationMethodElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.CanonicalizationMethodTypeCt" />
        /// </summary>
        [LxElementCt("CanonicalizationMethod", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.CanonicalizationMethodTypeCt CanonicalizationMethod { get; set; } = new krudos.FELgt.Documento012.Ds.CanonicalizationMethodElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.SignatureMethodTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.SignatureMethodElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.SignatureMethodTypeCt" />
        /// </summary>
        [LxElementCt("SignatureMethod", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 1, MaxOccurs = 1)]
        public krudos.FELgt.Documento012.Ds.SignatureMethodTypeCt SignatureMethod { get; set; } = new krudos.FELgt.Documento012.Ds.SignatureMethodElm();

        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.ReferenceTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.ReferenceElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.ReferenceTypeCt" />
        /// </summary>
        [LxElementCt("Reference", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.ReferenceTypeCt> References { get; } = new List<krudos.FELgt.Documento012.Ds.ReferenceTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType SPKIDataType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SPKIDataType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>230:1-235:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("SPKIDataType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SPKIDataTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A collection of <see cref="System.Byte" />[]</summary>
        [LxElementValue("SPKISexp", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Byte[]> SPKISexps { get; } = new List<System.Byte[]>();

        /// <summary>A collection of <see cref="XElement"/>'s to hold the additional elements described by an xs:any</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:SPKIDataType/sequence/any</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>233:5-233:67</XsdLocation>
        [LxElementAny(TargetNamespaceUri = "http://www.w3.org/2000/09/xmldsig#", Namespaces = new string[] { "##other"}, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<XElement> AnyElements { get; } = new List<XElement>();

    }

    /// <summary>A class representing the root XSD complexType TransformsType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:TransformsType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>109:3-113:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransformsType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformsTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.TransformTypeCt" />.<br/>
        ///   By default this would be a <see cref="krudos.FELgt.Documento012.Ds.TransformElm" />.<br/>
        ///   Other allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.TransformTypeCt" />
        /// </summary>
        [LxElementCt("Transform", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.TransformTypeCt> Transforms { get; } = new List<krudos.FELgt.Documento012.Ds.TransformTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType TransformType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:TransformType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>116:3-123:17</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransformType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformTypeCt : krudos.FELgt.Documento012.Xs.AnyTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType X509DataType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:X509DataType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>184:1-195:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("X509DataType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>
        ///   A class derived from <see cref="krudos.FELgt.Documento012.Ds.X509IssuerSerialTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="krudos.FELgt.Documento012.Ds.X509IssuerSerialTypeCt" />
        /// </summary>
        [LxElementCt("X509IssuerSerial", "http://www.w3.org/2000/09/xmldsig#", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<krudos.FELgt.Documento012.Ds.X509IssuerSerialTypeCt> X509IssuerSerials { get; } = new List<krudos.FELgt.Documento012.Ds.X509IssuerSerialTypeCt>();

        /// <summary>A collection of <see cref="System.Byte" />[]</summary>
        [LxElementValue("X509SKI", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Byte[]> X509SKIS { get; } = new List<System.Byte[]>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        [LxElementValue("X509SubjectName", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.String> X509SubjectNames { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.Byte" />[]</summary>
        [LxElementValue("X509Certificate", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Byte[]> X509Certificates { get; } = new List<System.Byte[]>();

        /// <summary>A collection of <see cref="System.Byte" />[]</summary>
        [LxElementValue("X509CRL", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdBase64Binary, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<System.Byte[]> X509CRLS { get; } = new List<System.Byte[]>();

        /// <summary>A collection of <see cref="XElement"/>'s to hold the additional elements described by an xs:any</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:X509DataType/sequence/choice/any</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>192:7-192:55</XsdLocation>
        [LxElementAny(TargetNamespaceUri = "http://www.w3.org/2000/09/xmldsig#", Namespaces = new string[] { "##other"}, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<XElement> AnyElements { get; } = new List<XElement>();

    }

    /// <summary>A class representing the root XSD complexType X509IssuerSerialType@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/complexType:X509IssuerSerialType</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>197:1-202:15</XsdLocation>
    [LxSimpleComplexTypeDefinition("X509IssuerSerialType", "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialTypeCt : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        [LxElementValue("X509IssuerName", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1)]
        public System.String X509IssuerName { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        [LxElementValue("X509SerialNumber", "http://www.w3.org/2000/09/xmldsig#", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1)]
        public System.Numerics.BigInteger X509SerialNumber { get; set; }

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element CanonicalizationMethod@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:CanonicalizationMethod</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>75:3-75:80</XsdLocation>
    [LxSimpleElementDefinition("CanonicalizationMethod", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class CanonicalizationMethodElm : krudos.FELgt.Documento012.Ds.CanonicalizationMethodTypeCt
    {
    }

    /// <summary>A class representing the root XSD element DigestMethod@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:DigestMethod</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>127:1-127:58</XsdLocation>
    [LxSimpleElementDefinition("DigestMethod", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class DigestMethodElm : krudos.FELgt.Documento012.Ds.DigestMethodTypeCt
    {
    }

    /// <summary>A class representing the root XSD element DigestValue@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:DigestValue</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>135:1-135:56</XsdLocation>
    [LxSimpleElementDefinition("DigestValue", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class DigestValueElm : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>Holds the <see cref="System.Byte" />[] value of the element</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/element:DigestValue</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>135:1-135:56</XsdLocation>
        [LxValue(LxValueType.Value, XsdType.XsdBase64Binary)]
        public System.Byte[] Value { get; set; } = new byte[0];

    }

    /// <summary>A class representing the root XSD element DSAKeyValue@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:DSAKeyValue</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>289:1-289:56</XsdLocation>
    [LxSimpleElementDefinition("DSAKeyValue", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class DSAKeyValueElm : krudos.FELgt.Documento012.Ds.DSAKeyValueTypeCt
    {
    }

    /// <summary>A class representing the root XSD element KeyInfo@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:KeyInfo</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>144:1-144:48</XsdLocation>
    [LxSimpleElementDefinition("KeyInfo", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class KeyInfoElm : krudos.FELgt.Documento012.Ds.KeyInfoTypeCt
    {
    }

    /// <summary>A class representing the root XSD element KeyName@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:KeyName</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>160:3-160:42</XsdLocation>
    [LxSimpleElementDefinition("KeyName", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class KeyNameElm : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>Holds the <see cref="System.String" /> (xs:http://www.w3.org/2001/XMLSchema:string) value of the element</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/element:KeyName</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>160:3-160:42</XsdLocation>
        [LxValue(LxValueType.Value, XsdType.XsdString)]
        public System.String Value { get; set; } = "";

    }

    /// <summary>A class representing the root XSD element KeyValue@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:KeyValue</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>163:3-163:52</XsdLocation>
    [LxSimpleElementDefinition("KeyValue", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class KeyValueElm : krudos.FELgt.Documento012.Ds.KeyValueTypeCt
    {
    }

    /// <summary>A class representing the root XSD element Manifest@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Manifest</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>253:1-253:50</XsdLocation>
    [LxSimpleElementDefinition("Manifest", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class ManifestElm : krudos.FELgt.Documento012.Ds.ManifestTypeCt
    {
    }

    /// <summary>A class representing the root XSD element MgmtData@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:MgmtData</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>161:3-161:43</XsdLocation>
    [LxSimpleElementDefinition("MgmtData", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class MgmtDataElm : krudos.FELgt.Documento012.LxBase
    {
        /// <summary>Holds the <see cref="System.String" /> (xs:http://www.w3.org/2001/XMLSchema:string) value of the element</summary>
        /// <XsdPath>schema:xmldsig-core-schema.xsd/element:MgmtData</XsdPath>
        /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
        /// <XsdLocation>161:3-161:43</XsdLocation>
        [LxValue(LxValueType.Value, XsdType.XsdString)]
        public System.String Value { get; set; } = "";

    }

    /// <summary>A class representing the root XSD element Object@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Object</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>243:1-243:46</XsdLocation>
    [LxSimpleElementDefinition("Object", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class Object_Elm : krudos.FELgt.Documento012.Ds.ObjectTypeCt
    {
    }

    /// <summary>A class representing the root XSD element PGPData@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:PGPData</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>208:1-208:48</XsdLocation>
    [LxSimpleElementDefinition("PGPData", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class PGPDataElm : krudos.FELgt.Documento012.Ds.PGPDataTypeCt
    {
    }

    /// <summary>A class representing the root XSD element Reference@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Reference</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>96:1-96:52</XsdLocation>
    [LxSimpleElementDefinition("Reference", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class ReferenceElm : krudos.FELgt.Documento012.Ds.ReferenceTypeCt
    {
    }

    /// <summary>A class representing the root XSD element RetrievalMethod@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:RetrievalMethod</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>172:3-172:66</XsdLocation>
    [LxSimpleElementDefinition("RetrievalMethod", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class RetrievalMethodElm : krudos.FELgt.Documento012.Ds.RetrievalMethodTypeCt
    {
    }

    /// <summary>A class representing the root XSD element RSAKeyValue@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:RSAKeyValue</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>306:1-306:56</XsdLocation>
    [LxSimpleElementDefinition("RSAKeyValue", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class RSAKeyValueElm : krudos.FELgt.Documento012.Ds.RSAKeyValueTypeCt
    {
    }

    /// <summary>A class representing the root XSD element Signature@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Signature</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>43:1-43:52</XsdLocation>
    [LxSimpleElementDefinition("Signature", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignatureElm : krudos.FELgt.Documento012.Ds.SignatureTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SignatureMethod@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SignatureMethod</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>84:3-84:66</XsdLocation>
    [LxSimpleElementDefinition("SignatureMethod", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignatureMethodElm : krudos.FELgt.Documento012.Ds.SignatureMethodTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SignatureProperties@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SignatureProperties</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>261:1-261:72</XsdLocation>
    [LxSimpleElementDefinition("SignatureProperties", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignaturePropertiesElm : krudos.FELgt.Documento012.Ds.SignaturePropertiesTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SignatureProperty@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SignatureProperty</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>269:4-269:71</XsdLocation>
    [LxSimpleElementDefinition("SignatureProperty", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignaturePropertyElm : krudos.FELgt.Documento012.Ds.SignaturePropertyTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SignatureValue@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SignatureValue</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>54:3-54:64</XsdLocation>
    [LxSimpleElementDefinition("SignatureValue", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignatureValueElm : krudos.FELgt.Documento012.Ds.SignatureValueTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SignedInfo@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SignedInfo</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>65:1-65:54</XsdLocation>
    [LxSimpleElementDefinition("SignedInfo", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SignedInfoElm : krudos.FELgt.Documento012.Ds.SignedInfoTypeCt
    {
    }

    /// <summary>A class representing the root XSD element SPKIData@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:SPKIData</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>229:1-229:50</XsdLocation>
    [LxSimpleElementDefinition("SPKIData", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class SPKIDataElm : krudos.FELgt.Documento012.Ds.SPKIDataTypeCt
    {
    }

    /// <summary>A class representing the root XSD element Transform@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Transform</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>115:3-115:54</XsdLocation>
    [LxSimpleElementDefinition("Transform", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class TransformElm : krudos.FELgt.Documento012.Ds.TransformTypeCt
    {
    }

    /// <summary>A class representing the root XSD element Transforms@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:Transforms</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>108:3-108:56</XsdLocation>
    [LxSimpleElementDefinition("Transforms", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class TransformsElm : krudos.FELgt.Documento012.Ds.TransformsTypeCt
    {
    }

    /// <summary>A class representing the root XSD element X509Data@http://www.w3.org/2000/09/xmldsig#</summary>
    /// <XsdPath>schema:xmldsig-core-schema.xsd/element:X509Data</XsdPath>
    /// <XsdFile>http://www.w3.org/TR/2002/REC-xmldsig-core-20020212/xmldsig-core-schema.xsd</XsdFile>
    /// <XsdLocation>183:1-183:50</XsdLocation>
    [LxSimpleElementDefinition("X509Data", "http://www.w3.org/2000/09/xmldsig#", ElementScopeType.GlobalElement)]
    public partial class X509DataElm : krudos.FELgt.Documento012.Ds.X509DataTypeCt
    {
    }

    #endregion

}

