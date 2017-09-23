﻿<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">x86</Platform>
    <ProductVersion>
    </ProductVersion>
    <SchemaVersion>2.0</SchemaVersion>
    <ProjectGuid>{AF4DB42D-AE00-40C8-AF2B-318B74215853}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <StartupObject>WindowsApplication1.My.MyApplication</StartupObject>
    <RootNamespace>WindowsApplication1</RootNamespace>
    <AssemblyName>VBImage2kana</AssemblyName>
    <FileAlignment>512</FileAlignment>
    <MyType>WindowsForms</MyType>
    <TargetFrameworkVersion>v4.0</TargetFrameworkVersion>
    <TargetFrameworkProfile>Client</TargetFrameworkProfile>
    <IsWebBootstrapper>false</IsWebBootstrapper>
    <PublishUrl>W:\msvs2010Projects\Release\VBI2K\</PublishUrl>
    <Install>true</Install>
    <InstallFrom>Disk</InstallFrom>
    <UpdateEnabled>false</UpdateEnabled>
    <UpdateMode>Foreground</UpdateMode>
    <UpdateInterval>7</UpdateInterval>
    <UpdateIntervalUnits>Days</UpdateIntervalUnits>
    <UpdatePeriodically>false</UpdatePeriodically>
    <UpdateRequired>false</UpdateRequired>
    <MapFileExtensions>true</MapFileExtensions>
    <UpdateUrl>http://localhost/VBImage2kana/</UpdateUrl>
    <WebPage>publish.htm</WebPage>
    <ApplicationRevision>0</ApplicationRevision>
    <ApplicationVersion>1.1.0.0</ApplicationVersion>
    <UseApplicationTrust>false</UseApplicationTrust>
    <CreateDesktopShortcut>true</CreateDesktopShortcut>
    <PublishWizardCompleted>true</PublishWizardCompleted>
    <BootstrapperEnabled>true</BootstrapperEnabled>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <DefineDebug>true</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <OutputPath>bin\Debug\</OutputPath>
    <DocumentationFile>VBImage2kana.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|x86' ">
    <PlatformTarget>x86</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <DefineDebug>false</DefineDebug>
    <DefineTrace>true</DefineTrace>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DocumentationFile>VBImage2kana.xml</DocumentationFile>
    <NoWarn>42016,41999,42017,42018,42019,42032,42036,42020,42021,42022</NoWarn>
  </PropertyGroup>
  <PropertyGroup>
    <OptionExplicit>On</OptionExplicit>
  </PropertyGroup>
  <PropertyGroup>
    <OptionCompare>Binary</OptionCompare>
  </PropertyGroup>
  <PropertyGroup>
    <OptionStrict>Off</OptionStrict>
  </PropertyGroup>
  <PropertyGroup>
    <OptionInfer>On</OptionInfer>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestCertificateThumbprint>0438468BFE081957D700B2C989987B25EC908A22</ManifestCertificateThumbprint>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestKeyFile>VBCert1.pfx</ManifestKeyFile>
  </PropertyGroup>
  <PropertyGroup>
    <GenerateManifests>true</GenerateManifests>
  </PropertyGroup>
  <PropertyGroup>
    <SignManifests>true</SignManifests>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationManifest>My Project\app.manifest</ApplicationManifest>
  </PropertyGroup>
  <PropertyGroup>
    <TargetZone>LocalIntranet</TargetZone>
  </PropertyGroup>
  <PropertyGroup>
    <ApplicationIcon>Icon-i2k.ico</ApplicationIcon>
  </PropertyGroup>
  <PropertyGroup>
    <ManifestTimestampUrl>http://timestamp.verisign.com/scripts/timstamp.dll</ManifestTimestampUrl>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.DirectoryServices" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
  </ItemGroup>
  <ItemGroup>
    <Import Include="Microsoft.VisualBasic" />
    <Import Include="System" />
    <Import Include="System.Collections" />
    <Import Include="System.Collections.Generic" />
    <Import Include="System.Data" />
    <Import Include="System.Drawing" />
    <Import Include="System.Diagnostics" />
    <Import Include="System.Windows.Forms" />
    <Import Include="System.Linq" />
    <Import Include="System.Xml.Linq" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="Class1.vb" />
    <Compile Include="Class2.vb" />
    <Compile Include="Class3.vb" />
    <Compile Include="Class4.vb" />
    <Compile Include="Class5.vb" />
    <Compile Include="Class6.vb" />
    <Compile Include="Class7.vb" />
    <Compile Include="Form1.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form1.Designer.vb">
      <DependentUpon>Form1.vb</DependentUpon>
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form10.Designer.vb">
      <DependentUpon>Form10.vb</DependentUpon>
    </Compile>
    <Compile Include="Form10.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form2.Designer.vb">
      <DependentUpon>Form2.vb</DependentUpon>
    </Compile>
    <Compile Include="Form2.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form3.Designer.vb">
      <DependentUpon>Form3.vb</DependentUpon>
    </Compile>
    <Compile Include="Form3.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form4.Designer.vb">
      <DependentUpon>Form4.vb</DependentUpon>
    </Compile>
    <Compile Include="Form4.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form5.Designer.vb">
      <DependentUpon>Form5.vb</DependentUpon>
    </Compile>
    <Compile Include="Form5.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form6.Designer.vb">
      <DependentUpon>Form6.vb</DependentUpon>
    </Compile>
    <Compile Include="Form6.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form7.Designer.vb">
      <DependentUpon>Form7.vb</DependentUpon>
    </Compile>
    <Compile Include="Form7.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form8.Designer.vb">
      <DependentUpon>Form8.vb</DependentUpon>
    </Compile>
    <Compile Include="Form8.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="Form9.Designer.vb">
      <DependentUpon>Form9.vb</DependentUpon>
    </Compile>
    <Compile Include="Form9.vb">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="My Project\AssemblyInfo.vb" />
    <Compile Include="My Project\Application.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Application.myapp</DependentUpon>
    </Compile>
    <Compile Include="My Project\Resources.Designer.vb">
      <AutoGen>True</AutoGen>
      <DesignTime>True</DesignTime>
      <DependentUpon>Resources.resx</DependentUpon>
    </Compile>
    <Compile Include="My Project\Settings.Designer.vb">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <EmbeddedResource Include="Form1.en-GB.resx">
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form1.is.resx">
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form1.resx">
      <DependentUpon>Form1.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form10.en-GB.resx">
      <DependentUpon>Form10.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form10.resx">
      <DependentUpon>Form10.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form2.en-GB.resx">
      <DependentUpon>Form2.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form2.resx">
      <DependentUpon>Form2.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form3.en-GB.resx">
      <DependentUpon>Form3.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form3.resx">
      <DependentUpon>Form3.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form4.resx">
      <DependentUpon>Form4.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form5.en-GB.resx">
      <DependentUpon>Form5.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form5.resx">
      <DependentUpon>Form5.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form6.en-GB.resx">
      <DependentUpon>Form6.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form6.resx">
      <DependentUpon>Form6.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form7.en-GB.resx">
      <DependentUpon>Form7.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form7.resx">
      <DependentUpon>Form7.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form8.en-GB.resx">
      <DependentUpon>Form8.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form8.is-IS.resx">
      <DependentUpon>Form8.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form8.resx">
      <DependentUpon>Form8.vb</DependentUpon>
    </EmbeddedResource>
    <None Include="My Project\Resources.en-GB.resx" />
    <EmbeddedResource Include="Form9.en-GB.resx">
      <DependentUpon>Form9.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Form9.resx">
      <DependentUpon>Form9.vb</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="My Project\Resources.resx">
      <Generator>VbMyResourcesResXFileCodeGenerator</Generator>
      <CustomToolNamespace>My.Resources</CustomToolNamespace>
      <SubType>Designer</SubType>
      <LastGenOutput>Resources1.Designer.vb</LastGenOutput>
    </EmbeddedResource>
  </ItemGroup>
  <ItemGroup>
    <None Include="app.config" />
    <None Include="My Project\app.manifest" />
    <None Include="My Project\Application.myapp">
      <Generator>MyApplicationCodeGenerator</Generator>
      <LastGenOutput>Application.Designer.vb</LastGenOutput>
    </None>
    <None Include="My Project\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <CustomToolNamespace>My</CustomToolNamespace>
      <LastGenOutput>Settings.Designer.vb</LastGenOutput>
    </None>
    <None Include="VBCert1.pfx" />
    <None Include="VBImage2kana_1_TemporaryKey.pfx" />
    <None Include="VBImage2kana_2_TemporaryKey.pfx" />
    <None Include="VBImage2kana_TemporaryKey.pfx" />
  </ItemGroup>
  <ItemGroup>
    <COMReference Include="MODI">
      <Guid>{A5EDEDF4-2BBC-45F3-822B-E60C278A1A79}</Guid>
      <VersionMajor>12</VersionMajor>
      <VersionMinor>0</VersionMinor>
      <Lcid>0</Lcid>
      <WrapperTool>tlbimp</WrapperTool>
      <Isolated>False</Isolated>
      <EmbedInteropTypes>True</EmbedInteropTypes>
    </COMReference>
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form3.txt" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form2.txt" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form5.txt" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form1U8.txt" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form6.txt" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form7.txt" />
  </ItemGroup>
  <ItemGroup>
    <BootstrapperPackage Include=".NETFramework,Version=v4.0,Profile=Client">
      <Visible>False</Visible>
      <ProductName>Microsoft .NET Framework 4 Client Profile %28x86 および x64%29</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Client.3.5">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1 Client Profile</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Net.Framework.3.5.SP1">
      <Visible>False</Visible>
      <ProductName>.NET Framework 3.5 SP1</ProductName>
      <Install>false</Install>
    </BootstrapperPackage>
    <BootstrapperPackage Include="Microsoft.Windows.Installer.3.1">
      <Visible>False</Visible>
      <ProductName>Windows インストーラー 3.1</ProductName>
      <Install>true</Install>
    </BootstrapperPackage>
  </ItemGroup>
  <ItemGroup>
    <WCFMetadata Include="Service References\" />
  </ItemGroup>
  <ItemGroup>
    <None Include="helps\help_form3E.txt" />
    <None Include="helps\help_form6E.txt" />
    <None Include="helps\help_form7E.txt" />
    <None Include="helps\help_form5E.txt" />
    <None Include="helps\help_form1E.txt" />
    <None Include="helps\help_form2E.txt" />
    <None Include="helps\help_form9.txt" />
    <None Include="helps\help_form9E.txt" />
    <Content Include="Icon-i2k.ico" />
    <None Include="icons\Icon-i2k.ico" />
    <None Include="icons\Icon-i2k.png" />
    <None Include="icons\Icon-i2k3232ColorResizeI2k.png" />
  </ItemGroup>
  <ItemGroup>
    <Folder Include="Resources\" />
  </ItemGroup>
  <Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" />
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name="BeforeBuild">
  </Target>
  <Target Name="AfterBuild">
  </Target>
  -->
</Project>