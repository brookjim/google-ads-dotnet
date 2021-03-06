// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/payments_account.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/payments_account.proto</summary>
  public static partial class PaymentsAccountReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/payments_account.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentsAccountReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvcGF5bWVudHNf",
            "YWNjb3VudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMu",
            "cHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ivAQKD1BheW1l",
            "bnRzQWNjb3VudBJHCg1yZXNvdXJjZV9uYW1lGAEgASgJQjDgQQP6QSoKKGdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9QYXltZW50c0FjY291bnQSPgoTcGF5",
            "bWVudHNfYWNjb3VudF9pZBgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJp",
            "bmdWYWx1ZUID4EEDEi8KBG5hbWUYAyABKAsyHC5nb29nbGUucHJvdG9idWYu",
            "U3RyaW5nVmFsdWVCA+BBAxI4Cg1jdXJyZW5jeV9jb2RlGAQgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMSPgoTcGF5bWVudHNfcHJv",
            "ZmlsZV9pZBgFIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID",
            "4EEDEkgKHXNlY29uZGFyeV9wYXltZW50c19wcm9maWxlX2lkGAYgASgLMhwu",
            "Z29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPgQQMSQgoXcGF5aW5nX21h",
            "bmFnZXJfY3VzdG9tZXIYByABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5n",
            "VmFsdWVCA+BBAzpn6kFkCihnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vUGF5",
            "bWVudHNBY2NvdW50EjhjdXN0b21lcnMve2N1c3RvbWVyfS9wYXltZW50c0Fj",
            "Y291bnRzL3twYXltZW50c19hY2NvdW50fUKBAgolY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYzLnJlc291cmNlc0IUUGF5bWVudHNBY2NvdW50UHJvdG9Q",
            "AVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YzL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMy5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWM1xSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMzo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.PaymentsAccount), global::Google.Ads.GoogleAds.V3.Resources.PaymentsAccount.Parser, new[]{ "ResourceName", "PaymentsAccountId", "Name", "CurrencyCode", "PaymentsProfileId", "SecondaryPaymentsProfileId", "PayingManagerCustomer" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A payments account, which can be used to set up billing for an Ads customer.
  /// </summary>
  public sealed partial class PaymentsAccount : pb::IMessage<PaymentsAccount> {
    private static readonly pb::MessageParser<PaymentsAccount> _parser = new pb::MessageParser<PaymentsAccount>(() => new PaymentsAccount());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PaymentsAccount> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.PaymentsAccountReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentsAccount() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentsAccount(PaymentsAccount other) : this() {
      resourceName_ = other.resourceName_;
      PaymentsAccountId = other.PaymentsAccountId;
      Name = other.Name;
      CurrencyCode = other.CurrencyCode;
      PaymentsProfileId = other.PaymentsProfileId;
      SecondaryPaymentsProfileId = other.SecondaryPaymentsProfileId;
      PayingManagerCustomer = other.PayingManagerCustomer;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentsAccount Clone() {
      return new PaymentsAccount(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the payments account.
    /// PaymentsAccount resource names have the form:
    ///
    /// `customers/{customer_id}/paymentsAccounts/{payments_account_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payments_account_id" field.</summary>
    public const int PaymentsAccountIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_paymentsAccountId_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string paymentsAccountId_;
    /// <summary>
    /// Output only. A 16 digit ID used to identify a payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PaymentsAccountId {
      get { return paymentsAccountId_; }
      set {
        paymentsAccountId_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// Output only. The name of the payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_currencyCode_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string currencyCode_;
    /// <summary>
    /// Output only. The currency code of the payments account.
    /// A subset of the currency codes derived from the ISO 4217 standard is
    /// supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrencyCode {
      get { return currencyCode_; }
      set {
        currencyCode_ = value;
      }
    }


    /// <summary>Field number for the "payments_profile_id" field.</summary>
    public const int PaymentsProfileIdFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_paymentsProfileId_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string paymentsProfileId_;
    /// <summary>
    /// Output only. A 12 digit ID used to identify the payments profile associated with the
    /// payments account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PaymentsProfileId {
      get { return paymentsProfileId_; }
      set {
        paymentsProfileId_ = value;
      }
    }


    /// <summary>Field number for the "secondary_payments_profile_id" field.</summary>
    public const int SecondaryPaymentsProfileIdFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_secondaryPaymentsProfileId_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string secondaryPaymentsProfileId_;
    /// <summary>
    /// Output only. A secondary payments profile ID present in uncommon situations, e.g.
    /// when a sequential liability agreement has been arranged.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SecondaryPaymentsProfileId {
      get { return secondaryPaymentsProfileId_; }
      set {
        secondaryPaymentsProfileId_ = value;
      }
    }


    /// <summary>Field number for the "paying_manager_customer" field.</summary>
    public const int PayingManagerCustomerFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _single_payingManagerCustomer_codec = pb::FieldCodec.ForClassWrapper<string>(58);
    private string payingManagerCustomer_;
    /// <summary>
    /// Output only. Paying manager of this payment account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PayingManagerCustomer {
      get { return payingManagerCustomer_; }
      set {
        payingManagerCustomer_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PaymentsAccount);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PaymentsAccount other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (PaymentsAccountId != other.PaymentsAccountId) return false;
      if (Name != other.Name) return false;
      if (CurrencyCode != other.CurrencyCode) return false;
      if (PaymentsProfileId != other.PaymentsProfileId) return false;
      if (SecondaryPaymentsProfileId != other.SecondaryPaymentsProfileId) return false;
      if (PayingManagerCustomer != other.PayingManagerCustomer) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (paymentsAccountId_ != null) hash ^= PaymentsAccountId.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (currencyCode_ != null) hash ^= CurrencyCode.GetHashCode();
      if (paymentsProfileId_ != null) hash ^= PaymentsProfileId.GetHashCode();
      if (secondaryPaymentsProfileId_ != null) hash ^= SecondaryPaymentsProfileId.GetHashCode();
      if (payingManagerCustomer_ != null) hash ^= PayingManagerCustomer.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (paymentsAccountId_ != null) {
        _single_paymentsAccountId_codec.WriteTagAndValue(output, PaymentsAccountId);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (currencyCode_ != null) {
        _single_currencyCode_codec.WriteTagAndValue(output, CurrencyCode);
      }
      if (paymentsProfileId_ != null) {
        _single_paymentsProfileId_codec.WriteTagAndValue(output, PaymentsProfileId);
      }
      if (secondaryPaymentsProfileId_ != null) {
        _single_secondaryPaymentsProfileId_codec.WriteTagAndValue(output, SecondaryPaymentsProfileId);
      }
      if (payingManagerCustomer_ != null) {
        _single_payingManagerCustomer_codec.WriteTagAndValue(output, PayingManagerCustomer);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (paymentsAccountId_ != null) {
        size += _single_paymentsAccountId_codec.CalculateSizeWithTag(PaymentsAccountId);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (currencyCode_ != null) {
        size += _single_currencyCode_codec.CalculateSizeWithTag(CurrencyCode);
      }
      if (paymentsProfileId_ != null) {
        size += _single_paymentsProfileId_codec.CalculateSizeWithTag(PaymentsProfileId);
      }
      if (secondaryPaymentsProfileId_ != null) {
        size += _single_secondaryPaymentsProfileId_codec.CalculateSizeWithTag(SecondaryPaymentsProfileId);
      }
      if (payingManagerCustomer_ != null) {
        size += _single_payingManagerCustomer_codec.CalculateSizeWithTag(PayingManagerCustomer);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PaymentsAccount other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.paymentsAccountId_ != null) {
        if (paymentsAccountId_ == null || other.PaymentsAccountId != "") {
          PaymentsAccountId = other.PaymentsAccountId;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.currencyCode_ != null) {
        if (currencyCode_ == null || other.CurrencyCode != "") {
          CurrencyCode = other.CurrencyCode;
        }
      }
      if (other.paymentsProfileId_ != null) {
        if (paymentsProfileId_ == null || other.PaymentsProfileId != "") {
          PaymentsProfileId = other.PaymentsProfileId;
        }
      }
      if (other.secondaryPaymentsProfileId_ != null) {
        if (secondaryPaymentsProfileId_ == null || other.SecondaryPaymentsProfileId != "") {
          SecondaryPaymentsProfileId = other.SecondaryPaymentsProfileId;
        }
      }
      if (other.payingManagerCustomer_ != null) {
        if (payingManagerCustomer_ == null || other.PayingManagerCustomer != "") {
          PayingManagerCustomer = other.PayingManagerCustomer;
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_paymentsAccountId_codec.Read(input);
            if (paymentsAccountId_ == null || value != "") {
              PaymentsAccountId = value;
            }
            break;
          }
          case 26: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 34: {
            string value = _single_currencyCode_codec.Read(input);
            if (currencyCode_ == null || value != "") {
              CurrencyCode = value;
            }
            break;
          }
          case 42: {
            string value = _single_paymentsProfileId_codec.Read(input);
            if (paymentsProfileId_ == null || value != "") {
              PaymentsProfileId = value;
            }
            break;
          }
          case 50: {
            string value = _single_secondaryPaymentsProfileId_codec.Read(input);
            if (secondaryPaymentsProfileId_ == null || value != "") {
              SecondaryPaymentsProfileId = value;
            }
            break;
          }
          case 58: {
            string value = _single_payingManagerCustomer_codec.Read(input);
            if (payingManagerCustomer_ == null || value != "") {
              PayingManagerCustomer = value;
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
