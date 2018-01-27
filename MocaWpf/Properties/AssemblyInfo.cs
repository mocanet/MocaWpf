using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyDescription("Moca.NET WPF")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("MiYABiS")]
[assembly: AssemblyProduct("Moca.NET Framework")]
[assembly: AssemblyCopyright("© MiYABiS All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、その型はこのアセンブリ内で COM コンポーネントから
// 参照不可能になります。COM からこのアセンブリ内の型にアクセスする場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

//ローカライズ可能なアプリケーションのビルドを開始するには、
//.csproj ファイルの <UICulture>CultureYouAreCodingWith</UICulture> を
//<PropertyGroup> 内部で設定します。たとえば、
//ソース ファイルで英語を使用している場合、<UICulture> を en-US に設定します。次に、
//下の NeutralResourceLanguage 属性のコメントを解除します。下の行の "en-US" を
//プロジェクト ファイルの UICulture 設定と一致するよう更新します。

//[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


[assembly:ThemeInfo(
    ResourceDictionaryLocation.None, //テーマ固有のリソース ディクショナリが置かれている場所
                             //(リソースがページ、
                             // またはアプリケーション リソース ディクショナリに見つからない場合に使用されます)
    ResourceDictionaryLocation.SourceAssembly //汎用リソース ディクショナリが置かれている場所
                                      //(リソースがページ、
                                      // アプリケーション、またはいずれのテーマ固有のリソース ディクショナリにも見つからない場合に使用されます)
)]


// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      Revision
//
// すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]


// プログラム要素が CLS (Common Language Specification) に準拠しているかどうかを示します
[assembly: System.CLSCompliant(true)]


[assembly: AssemblyVersion("1.0.0")]
[assembly: AssemblyFileVersion("1.0.0")]


#if net35
[assembly: AssemblyTitle("Moca.NET WPF .NET 3.5")]
#endif
#if net40
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.0")]
#endif
#if net45
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.5")]
#endif
#if net452
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.5.2")]
#endif
#if net46
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.6")]
#endif
#if net462
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.6.2")]
#endif
#if net47
[assembly: AssemblyTitle("Moca.NET WPF .NET 4.7")]
#endif
