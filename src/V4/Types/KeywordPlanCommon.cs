// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/common/keyword_plan_common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/common/keyword_plan_common.proto</summary>
  public static partial class KeywordPlanCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/common/keyword_plan_common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9jb21tb24va2V5d29yZF9wbGFu",
            "X2NvbW1vbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuY29tbW9u",
            "GkJnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9rZXl3b3JkX3BsYW5f",
            "Y29tcGV0aXRpb25fbGV2ZWwucHJvdG8aMWdvb2dsZS9hZHMvZ29vZ2xlYWRz",
            "L3Y0L2VudW1zL21vbnRoX29mX3llYXIucHJvdG8aHmdvb2dsZS9wcm90b2J1",
            "Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byLaAwocS2V5d29yZFBsYW5IaXN0b3JpY2FsTWV0cmljcxI5ChRhdmdfbW9u",
            "dGhseV9zZWFyY2hlcxgBIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZh",
            "bHVlElMKFm1vbnRobHlfc2VhcmNoX3ZvbHVtZXMYBiADKAsyMy5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52NC5jb21tb24uTW9udGhseVNlYXJjaFZvbHVtZRJv",
            "Cgtjb21wZXRpdGlvbhgCIAEoDjJaLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0",
            "LmVudW1zLktleXdvcmRQbGFuQ29tcGV0aXRpb25MZXZlbEVudW0uS2V5d29y",
            "ZFBsYW5Db21wZXRpdGlvbkxldmVsEjYKEWNvbXBldGl0aW9uX2luZGV4GAMg",
            "ASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWUSPwoabG93X3RvcF9v",
            "Zl9wYWdlX2JpZF9taWNyb3MYBCABKAsyGy5nb29nbGUucHJvdG9idWYuSW50",
            "NjRWYWx1ZRJAChtoaWdoX3RvcF9vZl9wYWdlX2JpZF9taWNyb3MYBSABKAsy",
            "Gy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZSLCAQoTTW9udGhseVNlYXJj",
            "aFZvbHVtZRIpCgR5ZWFyGAEgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0",
            "VmFsdWUSSQoFbW9udGgYAiABKA4yOi5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "NC5lbnVtcy5Nb250aE9mWWVhckVudW0uTW9udGhPZlllYXISNQoQbW9udGhs",
            "eV9zZWFyY2hlcxgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVl",
            "QvEBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuY29tbW9uQhZLZXl3",
            "b3JkUGxhbkNvbW1vblByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9jb21tb247Y29tbW9u",
            "ogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuQ29tbW9uygIeR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjRcQ29tbW9u6gIiR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjQ6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelReflection.Descriptor, global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Common.KeywordPlanHistoricalMetrics), global::Google.Ads.GoogleAds.V4.Common.KeywordPlanHistoricalMetrics.Parser, new[]{ "AvgMonthlySearches", "MonthlySearchVolumes", "Competition", "CompetitionIndex", "LowTopOfPageBidMicros", "HighTopOfPageBidMicros" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume), global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume.Parser, new[]{ "Year", "Month", "MonthlySearches" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Historical metrics specific to the targeting options selected.
  /// Targeting options include geographies, network, etc.
  /// Refer to https://support.google.com/google-ads/answer/3022575 for more
  /// details.
  /// </summary>
  public sealed partial class KeywordPlanHistoricalMetrics : pb::IMessage<KeywordPlanHistoricalMetrics> {
    private static readonly pb::MessageParser<KeywordPlanHistoricalMetrics> _parser = new pb::MessageParser<KeywordPlanHistoricalMetrics>(() => new KeywordPlanHistoricalMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanHistoricalMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Common.KeywordPlanCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics(KeywordPlanHistoricalMetrics other) : this() {
      AvgMonthlySearches = other.AvgMonthlySearches;
      monthlySearchVolumes_ = other.monthlySearchVolumes_.Clone();
      competition_ = other.competition_;
      CompetitionIndex = other.CompetitionIndex;
      LowTopOfPageBidMicros = other.LowTopOfPageBidMicros;
      HighTopOfPageBidMicros = other.HighTopOfPageBidMicros;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics Clone() {
      return new KeywordPlanHistoricalMetrics(this);
    }

    /// <summary>Field number for the "avg_monthly_searches" field.</summary>
    public const int AvgMonthlySearchesFieldNumber = 1;
    private static readonly pb::FieldCodec<long?> _single_avgMonthlySearches_codec = pb::FieldCodec.ForStructWrapper<long>(10);
    private long? avgMonthlySearches_;
    /// <summary>
    /// Approximate number of monthly searches on this query averaged
    /// for the past 12 months.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? AvgMonthlySearches {
      get { return avgMonthlySearches_; }
      set {
        avgMonthlySearches_ = value;
      }
    }


    /// <summary>Field number for the "monthly_search_volumes" field.</summary>
    public const int MonthlySearchVolumesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume> _repeated_monthlySearchVolumes_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume> monthlySearchVolumes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume>();
    /// <summary>
    /// Approximate number of searches on this query for the past twelve months.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V4.Common.MonthlySearchVolume> MonthlySearchVolumes {
      get { return monthlySearchVolumes_; }
    }

    /// <summary>Field number for the "competition" field.</summary>
    public const int CompetitionFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel competition_ = global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified;
    /// <summary>
    /// The competition level for the query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel Competition {
      get { return competition_; }
      set {
        competition_ = value;
      }
    }

    /// <summary>Field number for the "competition_index" field.</summary>
    public const int CompetitionIndexFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_competitionIndex_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? competitionIndex_;
    /// <summary>
    /// The competition index for the query in the range [0, 100].
    /// Shows how competitive ad placement is for a keyword.
    /// The level of competition from 0-100 is determined by the number of ad slots
    /// filled divided by the total number of ad slots available. If not enough
    /// data is available, null is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CompetitionIndex {
      get { return competitionIndex_; }
      set {
        competitionIndex_ = value;
      }
    }


    /// <summary>Field number for the "low_top_of_page_bid_micros" field.</summary>
    public const int LowTopOfPageBidMicrosFieldNumber = 4;
    private static readonly pb::FieldCodec<long?> _single_lowTopOfPageBidMicros_codec = pb::FieldCodec.ForStructWrapper<long>(34);
    private long? lowTopOfPageBidMicros_;
    /// <summary>
    /// Top of page bid low range (20th percentile) in micros for the keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? LowTopOfPageBidMicros {
      get { return lowTopOfPageBidMicros_; }
      set {
        lowTopOfPageBidMicros_ = value;
      }
    }


    /// <summary>Field number for the "high_top_of_page_bid_micros" field.</summary>
    public const int HighTopOfPageBidMicrosFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_highTopOfPageBidMicros_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? highTopOfPageBidMicros_;
    /// <summary>
    /// Top of page bid high range (80th percentile) in micros for the keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? HighTopOfPageBidMicros {
      get { return highTopOfPageBidMicros_; }
      set {
        highTopOfPageBidMicros_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanHistoricalMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanHistoricalMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvgMonthlySearches != other.AvgMonthlySearches) return false;
      if(!monthlySearchVolumes_.Equals(other.monthlySearchVolumes_)) return false;
      if (Competition != other.Competition) return false;
      if (CompetitionIndex != other.CompetitionIndex) return false;
      if (LowTopOfPageBidMicros != other.LowTopOfPageBidMicros) return false;
      if (HighTopOfPageBidMicros != other.HighTopOfPageBidMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (avgMonthlySearches_ != null) hash ^= AvgMonthlySearches.GetHashCode();
      hash ^= monthlySearchVolumes_.GetHashCode();
      if (Competition != global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) hash ^= Competition.GetHashCode();
      if (competitionIndex_ != null) hash ^= CompetitionIndex.GetHashCode();
      if (lowTopOfPageBidMicros_ != null) hash ^= LowTopOfPageBidMicros.GetHashCode();
      if (highTopOfPageBidMicros_ != null) hash ^= HighTopOfPageBidMicros.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (avgMonthlySearches_ != null) {
        _single_avgMonthlySearches_codec.WriteTagAndValue(output, AvgMonthlySearches);
      }
      if (Competition != global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Competition);
      }
      if (competitionIndex_ != null) {
        _single_competitionIndex_codec.WriteTagAndValue(output, CompetitionIndex);
      }
      if (lowTopOfPageBidMicros_ != null) {
        _single_lowTopOfPageBidMicros_codec.WriteTagAndValue(output, LowTopOfPageBidMicros);
      }
      if (highTopOfPageBidMicros_ != null) {
        _single_highTopOfPageBidMicros_codec.WriteTagAndValue(output, HighTopOfPageBidMicros);
      }
      monthlySearchVolumes_.WriteTo(output, _repeated_monthlySearchVolumes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (avgMonthlySearches_ != null) {
        size += _single_avgMonthlySearches_codec.CalculateSizeWithTag(AvgMonthlySearches);
      }
      size += monthlySearchVolumes_.CalculateSize(_repeated_monthlySearchVolumes_codec);
      if (Competition != global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Competition);
      }
      if (competitionIndex_ != null) {
        size += _single_competitionIndex_codec.CalculateSizeWithTag(CompetitionIndex);
      }
      if (lowTopOfPageBidMicros_ != null) {
        size += _single_lowTopOfPageBidMicros_codec.CalculateSizeWithTag(LowTopOfPageBidMicros);
      }
      if (highTopOfPageBidMicros_ != null) {
        size += _single_highTopOfPageBidMicros_codec.CalculateSizeWithTag(HighTopOfPageBidMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanHistoricalMetrics other) {
      if (other == null) {
        return;
      }
      if (other.avgMonthlySearches_ != null) {
        if (avgMonthlySearches_ == null || other.AvgMonthlySearches != 0L) {
          AvgMonthlySearches = other.AvgMonthlySearches;
        }
      }
      monthlySearchVolumes_.Add(other.monthlySearchVolumes_);
      if (other.Competition != global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        Competition = other.Competition;
      }
      if (other.competitionIndex_ != null) {
        if (competitionIndex_ == null || other.CompetitionIndex != 0L) {
          CompetitionIndex = other.CompetitionIndex;
        }
      }
      if (other.lowTopOfPageBidMicros_ != null) {
        if (lowTopOfPageBidMicros_ == null || other.LowTopOfPageBidMicros != 0L) {
          LowTopOfPageBidMicros = other.LowTopOfPageBidMicros;
        }
      }
      if (other.highTopOfPageBidMicros_ != null) {
        if (highTopOfPageBidMicros_ == null || other.HighTopOfPageBidMicros != 0L) {
          HighTopOfPageBidMicros = other.HighTopOfPageBidMicros;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            long? value = _single_avgMonthlySearches_codec.Read(input);
            if (avgMonthlySearches_ == null || value != 0L) {
              AvgMonthlySearches = value;
            }
            break;
          }
          case 16: {
            Competition = (global::Google.Ads.GoogleAds.V4.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel) input.ReadEnum();
            break;
          }
          case 26: {
            long? value = _single_competitionIndex_codec.Read(input);
            if (competitionIndex_ == null || value != 0L) {
              CompetitionIndex = value;
            }
            break;
          }
          case 34: {
            long? value = _single_lowTopOfPageBidMicros_codec.Read(input);
            if (lowTopOfPageBidMicros_ == null || value != 0L) {
              LowTopOfPageBidMicros = value;
            }
            break;
          }
          case 42: {
            long? value = _single_highTopOfPageBidMicros_codec.Read(input);
            if (highTopOfPageBidMicros_ == null || value != 0L) {
              HighTopOfPageBidMicros = value;
            }
            break;
          }
          case 50: {
            monthlySearchVolumes_.AddEntriesFrom(input, _repeated_monthlySearchVolumes_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Monthly search volume.
  /// </summary>
  public sealed partial class MonthlySearchVolume : pb::IMessage<MonthlySearchVolume> {
    private static readonly pb::MessageParser<MonthlySearchVolume> _parser = new pb::MessageParser<MonthlySearchVolume>(() => new MonthlySearchVolume());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonthlySearchVolume> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Common.KeywordPlanCommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonthlySearchVolume() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonthlySearchVolume(MonthlySearchVolume other) : this() {
      Year = other.Year;
      month_ = other.month_;
      MonthlySearches = other.MonthlySearches;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonthlySearchVolume Clone() {
      return new MonthlySearchVolume(this);
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 1;
    private static readonly pb::FieldCodec<long?> _single_year_codec = pb::FieldCodec.ForStructWrapper<long>(10);
    private long? year_;
    /// <summary>
    /// The year of the search volume (e.g. 2020).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }


    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear month_ = global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified;
    /// <summary>
    /// The month of the search volume.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    /// <summary>Field number for the "monthly_searches" field.</summary>
    public const int MonthlySearchesFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_monthlySearches_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? monthlySearches_;
    /// <summary>
    /// Approximate number of searches for the month.
    /// A null value indicates the search volume is unavailable for
    /// that month.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? MonthlySearches {
      get { return monthlySearches_; }
      set {
        monthlySearches_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonthlySearchVolume);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonthlySearchVolume other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      if (MonthlySearches != other.MonthlySearches) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (year_ != null) hash ^= Year.GetHashCode();
      if (Month != global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) hash ^= Month.GetHashCode();
      if (monthlySearches_ != null) hash ^= MonthlySearches.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (year_ != null) {
        _single_year_codec.WriteTagAndValue(output, Year);
      }
      if (Month != global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Month);
      }
      if (monthlySearches_ != null) {
        _single_monthlySearches_codec.WriteTagAndValue(output, MonthlySearches);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (year_ != null) {
        size += _single_year_codec.CalculateSizeWithTag(Year);
      }
      if (Month != global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Month);
      }
      if (monthlySearches_ != null) {
        size += _single_monthlySearches_codec.CalculateSizeWithTag(MonthlySearches);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MonthlySearchVolume other) {
      if (other == null) {
        return;
      }
      if (other.year_ != null) {
        if (year_ == null || other.Year != 0L) {
          Year = other.Year;
        }
      }
      if (other.Month != global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        Month = other.Month;
      }
      if (other.monthlySearches_ != null) {
        if (monthlySearches_ == null || other.MonthlySearches != 0L) {
          MonthlySearches = other.MonthlySearches;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            long? value = _single_year_codec.Read(input);
            if (year_ == null || value != 0L) {
              Year = value;
            }
            break;
          }
          case 16: {
            Month = (global::Google.Ads.GoogleAds.V4.Enums.MonthOfYearEnum.Types.MonthOfYear) input.ReadEnum();
            break;
          }
          case 26: {
            long? value = _single_monthlySearches_codec.Read(input);
            if (monthlySearches_ == null || value != 0L) {
              MonthlySearches = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
