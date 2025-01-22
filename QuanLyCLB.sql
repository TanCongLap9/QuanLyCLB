CREATE DATABASE QuanLyCLB
ALTER DATABASE QuanLyCLB SET CHANGE_TRACKING = ON (CHANGE_RETENTION = 1 DAYS, AUTO_CLEANUP = ON)
GO
USE QuanLyCLB
GO

/* Trước khi chạy các lệnh ở dưới, tiến hành thực hiện các bước sau:
- Sử dụng chức năng Replace All để thay thế tất cả các chuỗi 'C:\Users\User\source\repos\QuanLyCLB\hinh' bằng nơi lưu trữ các file
- Nhớ bật FILESTREAM trước khi chạy lệnh tạo bảng TapTin: SQL Server Configuration Manager > SQL Server > Properties > FILESTREAM > bật hết
- Rồi chạy các lệnh này: */
EXEC sp_configure 'filestream access level', 2
GO
RECONFIGURE
GO
ALTER DATABASE QuanLyCLB ADD FILEGROUP TapTinFS CONTAINS FILESTREAM 
GO
/* - Sau đó vào Database Properties > Files > Add File > Đặt tên TapTinFS > File Type: FILESTREAM */


-- #region QuyenHan

CREATE TABLE QuyenHan(
  MaQuyenHan varchar(10) NOT NULL,
  TenQuyenHan nvarchar(50) NOT NULL,
  CONSTRAINT PK_QuyenHan PRIMARY KEY CLUSTERED (MaQuyenHan)
)
GO
INSERT INTO QuyenHan VALUES
  ('Q-User', N'Quản trị viên'),
  ('Q-Admin', N'Người dùng')
GO

-- #endregion

-- #region MimeTypes

CREATE TABLE MimeTypes (
  FileExtension varchar(255) NOT NULL,
  MimeType varchar(255) NOT NULL,
  CONSTRAINT PK_MimeTypes PRIMARY KEY (FileExtension)
)
GO
CREATE FUNCTION GetMimeType(@FileExtension varchar(255)) RETURNS varchar(255) AS BEGIN
  RETURN (SELECT MimeType FROM MimeTypes WHERE FileExtension = @FileExtension)
END
GO
INSERT INTO MimeTypes(FileExtension, MimeType) VALUES
  ('.123', 'application/vnd.lotus-1-2-3'),
  ('.3dml', 'text/vnd.in3d.3dml'),
  ('.3g2', 'video/3gpp2'),
  ('.3gp', 'video/3gpp'),
  ('.a', 'application/octet-stream'),
  ('.aab', 'application/x-authorware-bin'),
  ('.aac', 'audio/x-aac'),
  ('.aam', 'application/x-authorware-map'),
  ('.aas', 'application/x-authorware-seg'),
  ('.abw', 'application/x-abiword'),
  ('.ac3', 'audio/ac3'),
  ('.acc', 'application/vnd.americandynamics.acc'),
  ('.accdb', 'application/vnd.ms-access'),
  ('.ace', 'application/x-ace-compressed'),
  ('.acu', 'application/vnd.acucobol'),
  ('.acutc', 'application/vnd.acucorp'),
  ('.adp', 'audio/adpcm'),
  ('.aep', 'application/vnd.audiograph'),
  ('.afm', 'application/x-font-type1'),
  ('.afp', 'application/vnd.ibm.modcap'),
  ('.ai', 'application/postscript'),
  ('.aif', 'audio/x-aiff'),
  ('.aifc', 'audio/x-aiff'),
  ('.aiff', 'audio/x-aiff'),
  ('.air', 'application/vnd.adobe.air-application-installer-package+zip'),
  ('.ami', 'application/vnd.amiga.ami'),
  ('.amr', 'audio/amr'),
  ('.ani', 'application/x-navi-animation'),
  ('.apk', 'application/vnd.android.package-archive'),
  ('.apng', 'image/apng'),
  ('.application', 'application/x-ms-application'),
  ('.apr', 'application/vnd.lotus-approach'),
  ('.asc', 'application/pgp-signature'),
  ('.asf', 'video/x-ms-asf'),
  ('.asm', 'text/x-asm'),
  ('.aso', 'application/vnd.accpac.simply.aso'),
  ('.asx', 'video/x-ms-asf'),
  ('.atc', 'application/vnd.acucorp'),
  ('.atom', 'application/atom+xml'),
  ('.atomcat', 'application/atomcat+xml'),
  ('.atomsvc', 'application/atomsvc+xml'),
  ('.atx', 'application/vnd.antix.game-component'),
  ('.au', 'audio/basic'),
  ('.avi', 'video/x-msvideo'),
  ('.avif', 'image/avif'),
  ('.aw', 'application/applixware'),
  ('.azf', 'application/vnd.airzip.filesecure.azf'),
  ('.azs', 'application/vnd.airzip.filesecure.azs'),
  ('.azw', 'application/vnd.amazon.ebook'),
  ('.bat', 'application/x-msdownload'),
  ('.bcpio', 'application/x-bcpio'),
  ('.bdf', 'application/x-font-bdf'),
  ('.bdm', 'application/vnd.syncml.dm+wbxml'),
  ('.bh2', 'application/vnd.fujitsu.oasysprs'),
  ('.bin', 'application/octet-stream'),
  ('.bmi', 'application/vnd.bmi'),
  ('.bmp', 'image/bmp'),
  ('.book', 'application/vnd.framemaker'),
  ('.box', 'application/vnd.previewsystems.box'),
  ('.boz', 'application/x-bzip2'),
  ('.bpk', 'application/octet-stream'),
  ('.btif', 'image/prs.btif'),
  ('.bz', 'application/x-bzip'),
  ('.bz2', 'application/x-bzip2'),
  ('.c', 'text/x-c'),
  ('.c4d', 'application/vnd.clonk.c4group'),
  ('.c4f', 'application/vnd.clonk.c4group'),
  ('.c4g', 'application/vnd.clonk.c4group'),
  ('.c4p', 'application/vnd.clonk.c4group'),
  ('.c4u', 'application/vnd.clonk.c4group'),
  ('.cab', 'application/vnd.ms-cab-compressed'),
  ('.car', 'application/vnd.curl.car'),
  ('.cat', 'application/vnd.ms-pki.seccat'),
  ('.cc', 'text/x-c'),
  ('.cct', 'application/x-director'),
  ('.ccxml', 'application/ccxml+xml'),
  ('.cdbcmsg', 'application/vnd.contact.cmsg'),
  ('.cdf', 'application/x-netcdf'),
  ('.cdkey', 'application/vnd.mediastation.cdkey'),
  ('.cdx', 'chemical/x-cdx'),
  ('.cdxml', 'application/vnd.chemdraw+xml'),
  ('.cdy', 'application/vnd.cinderella'),
  ('.cer', 'application/pkix-cert'),
  ('.cgm', 'image/cgm'),
  ('.chat', 'application/x-chat'),
  ('.chm', 'application/vnd.ms-htmlhelp'),
  ('.chrt', 'application/vnd.kde.kchart'),
  ('.cif', 'chemical/x-cif'),
  ('.cii', 'application/vnd.anser-web-certificate-issue-initiation'),
  ('.cil', 'application/vnd.ms-artgalry'),
  ('.cla', 'application/vnd.claymore'),
  ('.class', 'application/java-vm'),
  ('.clkk', 'application/vnd.crick.clicker.keyboard'),
  ('.clkp', 'application/vnd.crick.clicker.palette'),
  ('.clkt', 'application/vnd.crick.clicker.template'),
  ('.clkw', 'application/vnd.crick.clicker.wordbank'),
  ('.clkx', 'application/vnd.crick.clicker'),
  ('.clp', 'application/x-msclip'),
  ('.cmc', 'application/vnd.cosmocaller'),
  ('.cmdf', 'chemical/x-cmdf'),
  ('.cml', 'chemical/x-cml'),
  ('.cmp', 'application/vnd.yellowriver-custom-menu'),
  ('.cmx', 'image/x-cmx'),
  ('.cod', 'application/vnd.rim.cod'),
  ('.com', 'application/x-msdownload'),
  ('.conf', 'text/plain'),
  ('.cpio', 'application/x-cpio'),
  ('.cpp', 'text/x-c'),
  ('.cpt', 'application/mac-compactpro'),
  ('.crd', 'application/x-mscardfile'),
  ('.crl', 'application/pkix-crl'),
  ('.crt', 'application/x-x509-ca-cert'),
  ('.csh', 'application/x-csh'),
  ('.csml', 'chemical/x-csml'),
  ('.csp', 'application/vnd.commonspace'),
  ('.css', 'text/css'),
  ('.cst', 'application/x-director'),
  ('.csv', 'text/csv'),
  ('.cu', 'application/cu-seeme'),
  ('.cur', 'image/x-win-bitmap'),
  ('.curl', 'text/vnd.curl'),
  ('.cww', 'application/prs.cww'),
  ('.cxt', 'application/x-director'),
  ('.cxx', 'text/x-c'),
  ('.daf', 'application/vnd.mobius.daf'),
  ('.dataless', 'application/vnd.fdsn.seed'),
  ('.davmount', 'application/davmount+xml'),
  ('.dcr', 'application/x-director'),
  ('.dcurl', 'text/vnd.curl.dcurl'),
  ('.dd2', 'application/vnd.oma.dd2+xml'),
  ('.ddd', 'application/vnd.fujixerox.ddd'),
  ('.deb', 'application/x-debian-package'),
  ('.def', 'text/plain'),
  ('.deploy', 'application/octet-stream'),
  ('.der', 'application/x-x509-ca-cert'),
  ('.dfac', 'application/vnd.dreamfactory'),
  ('.dic', 'text/x-c'),
  ('.diff', 'text/plain'),
  ('.dir', 'application/x-director'),
  ('.dis', 'application/vnd.mobius.dis'),
  ('.dist', 'application/octet-stream'),
  ('.distz', 'application/octet-stream'),
  ('.djv', 'image/vnd.djvu'),
  ('.djvu', 'image/vnd.djvu'),
  ('.dll', 'application/x-msdownload'),
  ('.dmg', 'application/octet-stream'),
  ('.dms', 'application/octet-stream'),
  ('.dna', 'application/vnd.dna'),
  ('.doc', 'application/msword'),
  ('.docm', 'application/vnd.ms-word.document.macroenabled.12'),
  ('.docx', 'application/vnd.openxmlformats-officedocument.wordprocessingml.document'),
  ('.dot', 'application/msword'),
  ('.dotm', 'application/vnd.ms-word.template.macroenabled.12'),
  ('.dotx', 'application/vnd.openxmlformats-officedocument.wordprocessingml.template'),
  ('.dp', 'application/vnd.osgi.dp'),
  ('.dpg', 'application/vnd.dpgraph'),
  ('.dsc', 'text/prs.lines.tag'),
  ('.dtb', 'application/x-dtbook+xml'),
  ('.dtd', 'application/xml-dtd'),
  ('.dts', 'audio/vnd.dts'),
  ('.dtshd', 'audio/vnd.dts.hd'),
  ('.dump', 'application/octet-stream'),
  ('.dvi', 'application/x-dvi'),
  ('.dwf', 'model/vnd.dwf'),
  ('.dwg', 'image/vnd.dwg'),
  ('.dxf', 'image/vnd.dxf'),
  ('.dxp', 'application/vnd.spotfire.dxp'),
  ('.dxr', 'application/x-director'),
  ('.ecelp4800', 'audio/vnd.nuera.ecelp4800'),
  ('.ecelp7470', 'audio/vnd.nuera.ecelp7470'),
  ('.ecelp9600', 'audio/vnd.nuera.ecelp9600'),
  ('.ecma', 'application/ecmascript'),
  ('.edm', 'application/vnd.novadigm.edm'),
  ('.edx', 'application/vnd.novadigm.edx'),
  ('.efif', 'application/vnd.picsel'),
  ('.ei6', 'application/vnd.pg.osasli'),
  ('.elc', 'application/octet-stream'),
  ('.emf', 'image/emf'),
  ('.eml', 'message/rfc822'),
  ('.emma', 'application/emma+xml'),
  ('.eol', 'audio/vnd.digital-winds'),
  ('.eot', 'application/vnd.ms-fontobject'),
  ('.eps', 'application/postscript'),
  ('.epub', 'application/epub+zip'),
  ('.es3', 'application/vnd.eszigno3+xml'),
  ('.esf', 'application/vnd.epson.esf'),
  ('.et3', 'application/vnd.eszigno3+xml'),
  ('.etx', 'text/x-setext'),
  ('.exe', 'application/x-msdownload'),
  ('.ext', 'application/vnd.novadigm.ext'),
  ('.ez', 'application/andrew-inset'),
  ('.ez2', 'application/vnd.ezpix-album'),
  ('.ez3', 'application/vnd.ezpix-package'),
  ('.f', 'text/x-fortran'),
  ('.f4v', 'video/x-f4v'),
  ('.f77', 'text/x-fortran'),
  ('.f90', 'text/x-fortran'),
  ('.fbs', 'image/vnd.fastbidsheet'),
  ('.fdf', 'application/vnd.fdf'),
  ('.fe_launch', 'application/vnd.denovo.fcselayout-link'),
  ('.fg5', 'application/vnd.fujitsu.oasysgp'),
  ('.fgd', 'application/x-director'),
  ('.fh', 'image/x-freehand'),
  ('.fh4', 'image/x-freehand'),
  ('.fh5', 'image/x-freehand'),
  ('.fh7', 'image/x-freehand'),
  ('.fhc', 'image/x-freehand'),
  ('.fig', 'application/x-xfig'),
  ('.flac', 'audio/flac'),
  ('.fli', 'video/x-fli'),
  ('.flo', 'application/vnd.micrografx.flo'),
  ('.flv', 'video/x-flv'),
  ('.flw', 'application/vnd.kde.kivio'),
  ('.flx', 'text/vnd.fmi.flexstor'),
  ('.fly', 'text/vnd.fly'),
  ('.fm', 'application/vnd.framemaker'),
  ('.fnc', 'application/vnd.frogans.fnc'),
  ('.for', 'text/x-fortran'),
  ('.fpx', 'image/vnd.fpx'),
  ('.frame', 'application/vnd.framemaker'),
  ('.fsc', 'application/vnd.fsc.weblaunch'),
  ('.fst', 'image/vnd.fst'),
  ('.ftc', 'application/vnd.fluxtime.clip'),
  ('.fti', 'application/vnd.anser-web-funds-transfer-initiation'),
  ('.fvt', 'video/vnd.fvt'),
  ('.fzs', 'application/vnd.fuzzysheet'),
  ('.g3', 'image/g3fax'),
  ('.gac', 'application/vnd.groove-account'),
  ('.gdl', 'model/vnd.gdl'),
  ('.geo', 'application/vnd.dynageo'),
  ('.gex', 'application/vnd.geometry-explorer'),
  ('.ggb', 'application/vnd.geogebra.file'),
  ('.ggt', 'application/vnd.geogebra.tool'),
  ('.ghf', 'application/vnd.groove-help'),
  ('.gif', 'image/gif'),
  ('.gim', 'application/vnd.groove-identity-message'),
  ('.gitattributes', 'text/x-sh'),
  ('.gitignore', 'text/x-sh'),
  ('.gmx', 'application/vnd.gmx'),
  ('.gnumeric', 'application/x-gnumeric'),
  ('.gph', 'application/vnd.flographit'),
  ('.gqf', 'application/vnd.grafeq'),
  ('.gqs', 'application/vnd.grafeq'),
  ('.gram', 'application/srgs'),
  ('.gre', 'application/vnd.geometry-explorer'),
  ('.grv', 'application/vnd.groove-injector'),
  ('.grxml', 'application/srgs+xml'),
  ('.gsf', 'application/x-font-ghostscript'),
  ('.gtar', 'application/x-gtar'),
  ('.gtm', 'application/vnd.groove-tool-message'),
  ('.gtw', 'model/vnd.gtw'),
  ('.gv', 'text/vnd.graphviz'),
  ('.gz', 'application/x-gzip'),
  ('.h', 'text/x-c'),
  ('.h261', 'video/h261'),
  ('.h263', 'video/h263'),
  ('.h264', 'video/h264'),
  ('.hbci', 'application/vnd.hbci'),
  ('.hdf', 'application/x-hdf'),
  ('.hh', 'text/x-c'),
  ('.hlp', 'application/winhlp'),
  ('.hpgl', 'application/vnd.hp-hpgl'),
  ('.hpid', 'application/vnd.hp-hpid'),
  ('.hps', 'application/vnd.hp-hps'),
  ('.hqx', 'application/mac-binhex40'),
  ('.htke', 'application/vnd.kenameaapp'),
  ('.htm', 'text/html'),
  ('.html', 'text/html'),
  ('.hvd', 'application/vnd.yamaha.hv-dic'),
  ('.hvp', 'application/vnd.yamaha.hv-voice'),
  ('.hvs', 'application/vnd.yamaha.hv-script'),
  ('.icc', 'application/vnd.iccprofile'),
  ('.ice', 'x-conference/x-cooltalk'),
  ('.icm', 'application/vnd.iccprofile'),
  ('.ico', 'image/x-icon'),
  ('.ics', 'text/calendar'),
  ('.ief', 'image/ief'),
  ('.ifb', 'text/calendar'),
  ('.ifm', 'application/vnd.shana.informed.formdata'),
  ('.iges', 'model/iges'),
  ('.igl', 'application/vnd.igloader'),
  ('.igs', 'model/iges'),
  ('.igx', 'application/vnd.micrografx.igx'),
  ('.iif', 'application/vnd.shana.informed.interchange'),
  ('.imp', 'application/vnd.accpac.simply.imp'),
  ('.ims', 'application/vnd.ms-ims'),
  ('.in', 'text/plain'),
  ('.ipk', 'application/vnd.shana.informed.package'),
  ('.irm', 'application/vnd.ibm.rights-management'),
  ('.irp', 'application/vnd.irepository.package+xml'),
  ('.iso', 'application/octet-stream'),
  ('.itp', 'application/vnd.shana.informed.formtemplate'),
  ('.ivp', 'application/vnd.immervision-ivp'),
  ('.ivu', 'application/vnd.immervision-ivu'),
  ('.jad', 'text/vnd.sun.j2me.app-descriptor'),
  ('.jam', 'application/vnd.jam'),
  ('.jar', 'application/java-archive'),
  ('.java', 'text/x-java-source'),
  ('.jisp', 'application/vnd.jisp'),
  ('.jlt', 'application/vnd.hp-jlyt'),
  ('.jnlp', 'application/x-java-jnlp-file'),
  ('.joda', 'application/vnd.joost.joda-archive'),
  ('.jpe', 'image/jpeg'),
  ('.jpeg', 'image/jpeg'),
  ('.jpg', 'image/jpeg'),
  ('.jpgm', 'video/jpm'),
  ('.jpgv', 'video/jpeg'),
  ('.jpm', 'video/jpm'),
  ('.js', 'application/javascript'),
  ('.json', 'application/json'),
  ('.kar', 'audio/midi'),
  ('.karbon', 'application/vnd.kde.karbon'),
  ('.kfo', 'application/vnd.kde.kformula'),
  ('.kia', 'application/vnd.kidspiration'),
  ('.kil', 'application/x-killustrator'),
  ('.kml', 'application/vnd.google-earth.kml+xml'),
  ('.kmz', 'application/vnd.google-earth.kmz'),
  ('.kne', 'application/vnd.kinar'),
  ('.knp', 'application/vnd.kinar'),
  ('.kon', 'application/vnd.kde.kontour'),
  ('.kpr', 'application/vnd.kde.kpresenter'),
  ('.kpt', 'application/vnd.kde.kpresenter'),
  ('.ksh', 'text/plain'),
  ('.ksp', 'application/vnd.kde.kspread'),
  ('.ktr', 'application/vnd.kahootz'),
  ('.ktz', 'application/vnd.kahootz'),
  ('.kwd', 'application/vnd.kde.kword'),
  ('.kwt', 'application/vnd.kde.kword'),
  ('.latex', 'application/x-latex'),
  ('.lbd', 'application/vnd.llamagraphics.life-balance.desktop'),
  ('.lbe', 'application/vnd.llamagraphics.life-balance.exchange+xml'),
  ('.les', 'application/vnd.hhe.lesson-player'),
  ('.lha', 'application/octet-stream'),
  ('.link66', 'application/vnd.route66.link66+xml'),
  ('.list', 'text/plain'),
  ('.list3820', 'application/vnd.ibm.modcap'),
  ('.listafp', 'application/vnd.ibm.modcap'),
  ('.log', 'text/plain'),
  ('.lostxml', 'application/lost+xml'),
  ('.lrf', 'application/octet-stream'),
  ('.lrm', 'application/vnd.ms-lrm'),
  ('.ltf', 'application/vnd.frogans.ltf'),
  ('.lvp', 'audio/vnd.lucent.voice'),
  ('.lwp', 'application/vnd.lotus-wordpro'),
  ('.lzh', 'application/octet-stream'),
  ('.m13', 'application/x-msmediaview'),
  ('.m14', 'application/x-msmediaview'),
  ('.m1v', 'video/mpeg'),
  ('.m2a', 'audio/mpeg'),
  ('.m2v', 'video/mpeg'),
  ('.m3a', 'audio/mpeg'),
  ('.m3u', 'audio/x-mpegurl'),
  ('.m3u8', 'audio/x-mpegurl'),
  ('.m4a', 'audio/x-m4a'),
  ('.m4u', 'video/vnd.mpegurl'),
  ('.m4v', 'video/x-m4v'),
  ('.ma', 'application/mathematica'),
  ('.mag', 'application/vnd.ecowin.chart'),
  ('.maker', 'application/vnd.framemaker'),
  ('.man', 'text/troff'),
  ('.mat', 'application/matlab-mat'),
  ('.mathml', 'application/mathml+xml'),
  ('.mb', 'application/mathematica'),
  ('.mbk', 'application/vnd.mobius.mbk'),
  ('.mbox', 'application/mbox'),
  ('.mc1', 'application/vnd.medcalcdata'),
  ('.mcd', 'application/vnd.mcd'),
  ('.mcurl', 'text/vnd.curl.mcurl'),
  ('.md', 'text/markdown'),
  ('.mdb', 'application/x-msaccess'),
  ('.mdi', 'image/vnd.ms-modi'),
  ('.me', 'text/troff'),
  ('.mesh', 'model/mesh'),
  ('.mfm', 'application/vnd.mfmp'),
  ('.mgz', 'application/vnd.proteus.magazine'),
  ('.mht', 'message/rfc822'),
  ('.mhtml', 'message/rfc822'),
  ('.mid', 'audio/midi'),
  ('.midi', 'audio/midi'),
  ('.mif', 'application/vnd.mif'),
  ('.mime', 'message/rfc822'),
  ('.mj2', 'video/mj2'),
  ('.mjp2', 'video/mj2'),
  ('.mka', 'audio/x-matroska'),
  ('.mkv', 'video/x-matroska'),
  ('.mlp', 'application/vnd.dolby.mlp'),
  ('.mmd', 'application/vnd.chipnuts.karaoke-mmd'),
  ('.mmf', 'application/vnd.smaf'),
  ('.mmr', 'image/vnd.fujixerox.edmics-mmr'),
  ('.mny', 'application/x-msmoney'),
  ('.mobi', 'application/x-mobipocket-ebook'),
  ('.mov', 'video/quicktime'),
  ('.movie', 'video/x-sgi-movie'),
  ('.mp2', 'audio/mpeg'),
  ('.mp2a', 'audio/mpeg'),
  ('.mp3', 'audio/mpeg'),
  ('.mp4', 'video/mp4'),
  ('.mp4a', 'audio/mp4'),
  ('.mp4s', 'application/mp4'),
  ('.mp4v', 'video/mp4'),
  ('.mpa', 'video/mpeg'),
  ('.mpc', 'application/vnd.mophun.certificate'),
  ('.mpe', 'video/mpeg'),
  ('.mpeg', 'video/mpeg'),
  ('.mpg', 'video/mpeg'),
  ('.mpg4', 'video/mp4'),
  ('.mpga', 'audio/mpeg'),
  ('.mpkg', 'application/vnd.apple.installer+xml'),
  ('.mpm', 'application/vnd.blueice.multipass'),
  ('.mpn', 'application/vnd.mophun.application'),
  ('.mpp', 'application/vnd.ms-project'),
  ('.mpt', 'application/vnd.ms-project'),
  ('.mpy', 'application/vnd.ibm.minipay'),
  ('.mqy', 'application/vnd.mobius.mqy'),
  ('.mrc', 'application/marc'),
  ('.ms', 'text/troff'),
  ('.mscml', 'application/mediaservercontrol+xml'),
  ('.mseed', 'application/vnd.fdsn.mseed'),
  ('.mseq', 'application/vnd.mseq'),
  ('.msf', 'application/vnd.epson.msf'),
  ('.msh', 'model/mesh'),
  ('.msi', 'application/x-msdownload'),
  ('.msl', 'application/vnd.mobius.msl'),
  ('.msty', 'application/vnd.muvee.style'),
  ('.mts', 'model/vnd.mts'),
  ('.mus', 'application/vnd.musician'),
  ('.musicxml', 'application/vnd.recordare.musicxml+xml'),
  ('.mvb', 'application/x-msmediaview'),
  ('.mwf', 'application/vnd.mfer'),
  ('.mxf', 'application/mxf'),
  ('.mxl', 'application/vnd.recordare.musicxml'),
  ('.mxml', 'application/xv+xml'),
  ('.mxs', 'application/vnd.triscape.mxs'),
  ('.mxu', 'video/vnd.mpegurl'),
  ('.n-gage', 'application/vnd.nokia.n-gage.symbian.install'),
  ('.nb', 'application/mathematica'),
  ('.nc', 'application/x-netcdf'),
  ('.ncx', 'application/x-dtbncx+xml'),
  ('.ngdat', 'application/vnd.nokia.n-gage.data'),
  ('.nlu', 'application/vnd.neurolanguage.nlu'),
  ('.nml', 'application/vnd.enliven'),
  ('.nnd', 'application/vnd.noblenet-directory'),
  ('.nns', 'application/vnd.noblenet-sealer'),
  ('.nnw', 'application/vnd.noblenet-web'),
  ('.npmignore', 'text/x-sh'),
  ('.npx', 'image/vnd.net-fpx'),
  ('.nsf', 'application/vnd.lotus-notes'),
  ('.nws', 'message/rfc822'),
  ('.o', 'application/octet-stream'),
  ('.oa2', 'application/vnd.fujitsu.oasys2'),
  ('.oa3', 'application/vnd.fujitsu.oasys3'),
  ('.oas', 'application/vnd.fujitsu.oasys'),
  ('.obd', 'application/x-msbinder'),
  ('.obj', 'application/octet-stream'),
  ('.oda', 'application/oda'),
  ('.odb', 'application/vnd.oasis.opendocument.database'),
  ('.odc', 'application/vnd.oasis.opendocument.chart'),
  ('.odf', 'application/vnd.oasis.opendocument.formula'),
  ('.odft', 'application/vnd.oasis.opendocument.formula-template'),
  ('.odg', 'application/vnd.oasis.opendocument.graphics'),
  ('.odi', 'application/vnd.oasis.opendocument.image'),
  ('.odp', 'application/vnd.oasis.opendocument.presentation'),
  ('.ods', 'application/vnd.oasis.opendocument.spreadsheet'),
  ('.odt', 'application/vnd.oasis.opendocument.text'),
  ('.oga', 'audio/ogg'),
  ('.ogg', 'audio/ogg'),
  ('.ogv', 'video/ogg'),
  ('.ogx', 'application/ogg'),
  ('.onepkg', 'application/onenote'),
  ('.onetmp', 'application/onenote'),
  ('.onetoc', 'application/onenote'),
  ('.onetoc2', 'application/onenote'),
  ('.opf', 'application/oebps-package+xml'),
  ('.oprc', 'application/vnd.palm'),
  ('.opus', 'audio/opus' ),
  ('.org', 'application/vnd.lotus-organizer'),
  ('.osf', 'application/vnd.yamaha.openscoreformat'),
  ('.osfpvg', 'application/vnd.yamaha.openscoreformat.osfpvg+xml'),
  ('.otc', 'application/vnd.oasis.opendocument.chart-template'),
  ('.otf', 'application/x-font-otf'),
  ('.otg', 'application/vnd.oasis.opendocument.graphics-template'),
  ('.oth', 'application/vnd.oasis.opendocument.text-web'),
  ('.oti', 'application/vnd.oasis.opendocument.image-template'),
  ('.otm', 'application/vnd.oasis.opendocument.text-master'),
  ('.otp', 'application/vnd.oasis.opendocument.presentation-template'),
  ('.ots', 'application/vnd.oasis.opendocument.spreadsheet-template'),
  ('.ott', 'application/vnd.oasis.opendocument.text-template'),
  ('.oxt', 'application/vnd.openofficeorg.extension'),
  ('.p', 'text/x-pascal'),
  ('.p10', 'application/pkcs10'),
  ('.p12', 'application/x-pkcs12'),
  ('.p7b', 'application/x-pkcs7-certificates'),
  ('.p7c', 'application/pkcs7-mime'),
  ('.p7m', 'application/pkcs7-mime'),
  ('.p7r', 'application/x-pkcs7-certreqresp'),
  ('.p7s', 'application/pkcs7-signature'),
  ('.pas', 'text/x-pascal'),
  ('.pbd', 'application/vnd.powerbuilder6'),
  ('.pbm', 'image/x-portable-bitmap'),
  ('.pcf', 'application/x-font-pcf'),
  ('.pcl', 'application/vnd.hp-pcl'),
  ('.pclxl', 'application/vnd.hp-pclxl'),
  ('.pct', 'image/x-pict'),
  ('.pcurl', 'application/vnd.curl.pcurl'),
  ('.pcx', 'image/x-pcx'),
  ('.pdb', 'application/vnd.palm'),
  ('.pdf', 'application/pdf'),
  ('.pfa', 'application/x-font-type1'),
  ('.pfb', 'application/x-font-type1'),
  ('.pfm', 'application/x-font-type1'),
  ('.pfr', 'application/font-tdpfr'),
  ('.pfx', 'application/x-pkcs12'),
  ('.pgm', 'image/x-portable-graymap'),
  ('.pgn', 'application/x-chess-pgn'),
  ('.pgp', 'application/pgp-encrypted'),
  ('.pic', 'image/x-pict'),
  ('.pkg', 'application/octet-stream'),
  ('.pki', 'application/pkixcmp'),
  ('.pkipath', 'application/pkix-pkipath'),
  ('.pl', 'text/plain'),
  ('.plb', 'application/vnd.3gpp.pic-bw-large'),
  ('.plc', 'application/vnd.mobius.plc'),
  ('.plf', 'application/vnd.pocketlearn'),
  ('.pls', 'application/pls+xml'),
  ('.pml', 'application/vnd.ctc-posml'),
  ('.png', 'image/png'),
  ('.pnm', 'image/x-portable-anymap'),
  ('.portpkg', 'application/vnd.macports.portpkg'),
  ('.pot', 'application/vnd.ms-powerpoint'),
  ('.potm', 'application/vnd.ms-powerpoint.template.macroenabled.12'),
  ('.potx', 'application/vnd.openxmlformats-officedocument.presentationml.template'),
  ('.ppa', 'application/vnd.ms-powerpoint'),
  ('.ppam', 'application/vnd.ms-powerpoint.addin.macroenabled.12'),
  ('.ppd', 'application/vnd.cups-ppd'),
  ('.ppm', 'image/x-portable-pixmap'),
  ('.pps', 'application/vnd.ms-powerpoint'),
  ('.ppsm', 'application/vnd.ms-powerpoint.slideshow.macroenabled.12'),
  ('.ppsx', 'application/vnd.openxmlformats-officedocument.presentationml.slideshow'),
  ('.ppt', 'application/vnd.ms-powerpoint'),
  ('.pptm', 'application/vnd.ms-powerpoint.presentation.macroenabled.12'),
  ('.pptx', 'application/vnd.openxmlformats-officedocument.presentationml.presentation'),
  ('.pqa', 'application/vnd.palm'),
  ('.prc', 'application/x-mobipocket-ebook'),
  ('.pre', 'application/vnd.lotus-freelance'),
  ('.prf', 'application/pics-rules'),
  ('.ps', 'application/postscript'),
  ('.psb', 'application/vnd.3gpp.pic-bw-small'),
  ('.psd', 'image/vnd.adobe.photoshop'),
  ('.psf', 'application/x-font-linux-psf'),
  ('.ptid', 'application/vnd.pvi.ptid1'),
  ('.pub', 'application/x-mspublisher'),
  ('.pvb', 'application/vnd.3gpp.pic-bw-var'),
  ('.pwn', 'application/vnd.3m.post-it-notes'),
  ('.pwz', 'application/vnd.ms-powerpoint'),
  ('.py', 'text/x-python'),
  ('.pya', 'audio/vnd.ms-playready.media.pya'),
  ('.pyc', 'application/x-python-code'),
  ('.pyo', 'application/x-python-code'),
  ('.pyv', 'video/vnd.ms-playready.media.pyv'),
  ('.qam', 'application/vnd.epson.quickanime'),
  ('.qbo', 'application/vnd.intu.qbo'),
  ('.qfx', 'application/vnd.intu.qfx'),
  ('.qps', 'application/vnd.publishare-delta-tree'),
  ('.qt', 'video/quicktime'),
  ('.qwd', 'application/vnd.quark.quarkxpress'),
  ('.qwt', 'application/vnd.quark.quarkxpress'),
  ('.qxb', 'application/vnd.quark.quarkxpress'),
  ('.qxd', 'application/vnd.quark.quarkxpress'),
  ('.qxl', 'application/vnd.quark.quarkxpress'),
  ('.qxt', 'application/vnd.quark.quarkxpress'),
  ('.ra', 'audio/x-pn-realaudio'),
  ('.ram', 'audio/x-pn-realaudio'),
  ('.rar', 'application/x-rar-compressed'),
  ('.ras', 'image/x-cmu-raster'),
  ('.rcprofile', 'application/vnd.ipunplugged.rcprofile'),
  ('.rdf', 'application/rdf+xml'),
  ('.rdz', 'application/vnd.data-vision.rdz'),
  ('.rep', 'application/vnd.businessobjects'),
  ('.res', 'application/x-dtbresource+xml'),
  ('.rgb', 'image/x-rgb'),
  ('.rif', 'application/reginfo+xml'),
  ('.riff', 'application/x-riff'),
  ('.rl', 'application/resource-lists+xml'),
  ('.rlc', 'image/vnd.fujixerox.edmics-rlc'),
  ('.rld', 'application/resource-lists-diff+xml'),
  ('.rm', 'application/vnd.rn-realmedia'),
  ('.rmi', 'audio/midi'),
  ('.rmp', 'audio/x-pn-realaudio-plugin'),
  ('.rms', 'application/vnd.jcp.javame.midlet-rms'),
  ('.rnc', 'application/relax-ng-compact-syntax'),
  ('.roff', 'text/troff'),
  ('.rpm', 'application/x-rpm'),
  ('.rpss', 'application/vnd.nokia.radio-presets'),
  ('.rpst', 'application/vnd.nokia.radio-preset'),
  ('.rq', 'application/sparql-query'),
  ('.rs', 'application/rls-services+xml'),
  ('.rsd', 'application/rsd+xml'),
  ('.rss', 'application/rss+xml'),
  ('.rtf', 'application/rtf'),
  ('.rtx', 'text/richtext'),
  ('.s', 'text/x-asm'),
  ('.saf', 'application/vnd.yamaha.smaf-audio'),
  ('.sbml', 'application/sbml+xml'),
  ('.sc', 'application/vnd.ibm.secure-container'),
  ('.scd', 'application/x-msschedule'),
  ('.scm', 'application/vnd.lotus-screencam'),
  ('.scq', 'application/scvp-cv-request'),
  ('.scs', 'application/scvp-cv-response'),
  ('.scurl', 'text/vnd.curl.scurl'),
  ('.sda', 'application/vnd.stardivision.draw'),
  ('.sdc', 'application/vnd.stardivision.calc'),
  ('.sdd', 'application/vnd.stardivision.impress'),
  ('.sdkd', 'application/vnd.solent.sdkm+xml'),
  ('.sdkm', 'application/vnd.solent.sdkm+xml'),
  ('.sdp', 'application/sdp'),
  ('.sdw', 'application/vnd.stardivision.writer'),
  ('.see', 'application/vnd.seemail'),
  ('.seed', 'application/vnd.fdsn.seed'),
  ('.sema', 'application/vnd.sema'),
  ('.semd', 'application/vnd.semd'),
  ('.semf', 'application/vnd.semf'),
  ('.ser', 'application/java-serialized-object'),
  ('.setpay', 'application/set-payment-initiation'),
  ('.setreg', 'application/set-registration-initiation'),
  ('.sfd-hdstx', 'application/vnd.hydrostatix.sof-data'),
  ('.sfs', 'application/vnd.spotfire.sfs'),
  ('.sgl', 'application/vnd.stardivision.writer-global'),
  ('.sgm', 'text/sgml'),
  ('.sgml', 'text/sgml'),
  ('.sh', 'application/x-sh'),
  ('.shar', 'application/x-shar'),
  ('.shf', 'application/shf+xml'),
  ('.si', 'text/vnd.wap.si'),
  ('.sic', 'application/vnd.wap.sic'),
  ('.sig', 'application/pgp-signature'),
  ('.silo', 'model/mesh'),
  ('.sis', 'application/vnd.symbian.install'),
  ('.sisx', 'application/vnd.symbian.install'),
  ('.sit', 'application/x-stuffit'),
  ('.sitx', 'application/x-stuffitx'),
  ('.skd', 'application/vnd.koan'),
  ('.skm', 'application/vnd.koan'),
  ('.skp', 'application/vnd.koan'),
  ('.skt', 'application/vnd.koan'),
  ('.sl', 'text/vnd.wap.sl'),
  ('.slc', 'application/vnd.wap.slc'),
  ('.sldm', 'application/vnd.ms-powerpoint.slide.macroenabled.12'),
  ('.sldx', 'application/vnd.openxmlformats-officedocument.presentationml.slide'),
  ('.slt', 'application/vnd.epson.salt'),
  ('.smf', 'application/vnd.stardivision.math'),
  ('.smi', 'application/smil+xml'),
  ('.smil', 'application/smil+xml'),
  ('.snd', 'audio/basic'),
  ('.snf', 'application/x-font-snf'),
  ('.so', 'application/octet-stream'),
  ('.spc', 'application/x-pkcs7-certificates'),
  ('.spf', 'application/vnd.yamaha.smaf-phrase'),
  ('.spl', 'application/x-futuresplash'),
  ('.spot', 'text/vnd.in3d.spot'),
  ('.spp', 'application/scvp-vp-response'),
  ('.spq', 'application/scvp-vp-request'),
  ('.spx', 'audio/ogg'),
  ('.sql', 'application/sql'),
  ('.src', 'application/x-wais-source'),
  ('.srx', 'application/sparql-results+xml'),
  ('.sse', 'application/vnd.kodak-descriptor'),
  ('.ssf', 'application/vnd.epson.ssf'),
  ('.ssml', 'application/ssml+xml'),
  ('.stc', 'application/vnd.sun.xml.calc.template'),
  ('.std', 'application/vnd.sun.xml.draw.template'),
  ('.stf', 'application/vnd.wt.stf'),
  ('.sti', 'application/vnd.sun.xml.impress.template'),
  ('.stk', 'application/hyperstudio'),
  ('.stl', 'application/vnd.ms-pki.stl'),
  ('.str', 'application/vnd.pg.format'),
  ('.stw', 'application/vnd.sun.xml.writer.template'),
  ('.sus', 'application/vnd.sus-calendar'),
  ('.susp', 'application/vnd.sus-calendar'),
  ('.sv4cpio', 'application/x-sv4cpio'),
  ('.sv4crc', 'application/x-sv4crc'),
  ('.svd', 'application/vnd.svd'),
  ('.svg', 'image/svg+xml'),
  ('.svgz', 'image/svg+xml'),
  ('.swa', 'application/x-director'),
  ('.swf', 'application/x-shockwave-flash'),
  ('.swi', 'application/vnd.arastra.swi'),
  ('.sxc', 'application/vnd.sun.xml.calc'),
  ('.sxd', 'application/vnd.sun.xml.draw'),
  ('.sxg', 'application/vnd.sun.xml.writer.global'),
  ('.sxi', 'application/vnd.sun.xml.impress'),
  ('.sxm', 'application/vnd.sun.xml.math'),
  ('.sxw', 'application/vnd.sun.xml.writer'),
  ('.t', 'text/troff'),
  ('.tao', 'application/vnd.tao.intent-module-archive'),
  ('.tar', 'application/x-tar'),
  ('.tcap', 'application/vnd.3gpp2.tcap'),
  ('.tcl', 'application/x-tcl'),
  ('.teacher', 'application/vnd.smart.teacher'),
  ('.tex', 'application/x-tex'),
  ('.texi', 'application/x-texinfo'),
  ('.texinfo', 'application/x-texinfo'),
  ('.text', 'text/plain'),
  ('.tfm', 'application/x-tex-tfm'),
  ('.tga', 'image/x-tga'),
  ('.tgz', 'application/x-gzip'),
  ('.tif', 'image/tiff'),
  ('.tiff', 'image/tiff'),
  ('.tmo', 'application/vnd.tmobile-livetv'),
  ('.torrent', 'application/x-bittorrent'),
  ('.tpl', 'application/vnd.groove-tool-template'),
  ('.tpt', 'application/vnd.trid.tpt'),
  ('.tr', 'text/troff'),
  ('.tra', 'application/vnd.trueapp'),
  ('.trm', 'application/x-msterminal'),
  ('.ts', 'application/typescript'),
  ('.tsv', 'text/tab-separated-values'),
  ('.ttc', 'application/x-font-ttf'),
  ('.ttf', 'application/x-font-ttf'),
  ('.twd', 'application/vnd.simtech-mindmapper'),
  ('.twds', 'application/vnd.simtech-mindmapper'),
  ('.txd', 'application/vnd.genomatix.tuxedo'),
  ('.txf', 'application/vnd.mobius.txf'),
  ('.txt', 'text/plain'),
  ('.u32', 'application/x-authorware-bin'),
  ('.udeb', 'application/x-debian-package'),
  ('.ufd', 'application/vnd.ufdl'),
  ('.ufdl', 'application/vnd.ufdl'),
  ('.umj', 'application/vnd.umajin'),
  ('.unityweb', 'application/vnd.unity'),
  ('.uoml', 'application/vnd.uoml+xml'),
  ('.uri', 'text/uri-list'),
  ('.uris', 'text/uri-list'),
  ('.urls', 'text/uri-list'),
  ('.ustar', 'application/x-ustar'),
  ('.utz', 'application/vnd.uiq.theme'),
  ('.uu', 'text/x-uuencode'),
  ('.vcd', 'application/x-cdlink'),
  ('.vcf', 'text/x-vcard'),
  ('.vcg', 'application/vnd.groove-vcard'),
  ('.vcs', 'text/x-vcalendar'),
  ('.vcx', 'application/vnd.vcx'),
  ('.vis', 'application/vnd.visionary'),
  ('.viv', 'video/vnd.vivo'),
  ('.vor', 'application/vnd.stardivision.writer'),
  ('.vox', 'application/x-authorware-bin'),
  ('.vrml', 'model/vrml'),
  ('.vsd', 'application/vnd.visio'),
  ('.vsf', 'application/vnd.vsf'),
  ('.vss', 'application/vnd.visio'),
  ('.vst', 'application/vnd.visio'),
  ('.vsw', 'application/vnd.visio'),
  ('.vtu', 'model/vnd.vtu'),
  ('.vxml', 'application/voicexml+xml'),
  ('.w3d', 'application/x-director'),
  ('.wad', 'application/x-doom'),
  ('.wav', 'audio/x-wav'),
  ('.wax', 'audio/x-ms-wax'),
  ('.wbmp', 'image/vnd.wap.wbmp'),
  ('.wbs', 'application/vnd.criticaltools.wbs+xml'),
  ('.wbxml', 'application/vnd.wap.wbxml'),
  ('.wcm', 'application/vnd.ms-works'),
  ('.wdb', 'application/vnd.ms-works'),
  ('.webm', 'video/webm'),
  ('.webp', 'image/webp'),
  ('.wiz', 'application/msword'),
  ('.wks', 'application/vnd.ms-works'),
  ('.wm', 'video/x-ms-wm'),
  ('.wma', 'audio/x-ms-wma'),
  ('.wmd', 'application/x-ms-wmd'),
  ('.wmf', 'application/x-msmetafile'),
  ('.wml', 'text/vnd.wap.wml'),
  ('.wmlc', 'application/vnd.wap.wmlc'),
  ('.wmls', 'text/vnd.wap.wmlscript'),
  ('.wmlsc', 'application/vnd.wap.wmlscriptc'),
  ('.wmp', 'image/vnd.ms-photo'),
  ('.wmv', 'video/x-ms-wmv'),
  ('.wmx', 'video/x-ms-wmx'),
  ('.wmz', 'application/x-ms-wmz'),
  ('.wpd', 'application/vnd.wordperfect'),
  ('.wpl', 'application/vnd.ms-wpl'),
  ('.wps', 'application/vnd.ms-works'),
  ('.wqd', 'application/vnd.wqd'),
  ('.wri', 'application/x-mswrite'),
  ('.wrl', 'model/vrml'),
  ('.wsdl', 'application/wsdl+xml'),
  ('.wspolicy', 'application/wspolicy+xml'),
  ('.wtb', 'application/vnd.webturbo'),
  ('.wvx', 'video/x-ms-wvx'),
  ('.x32', 'application/x-authorware-bin'),
  ('.x3d', 'application/vnd.hzn-3d-crossword'),
  ('.xap', 'application/x-silverlight-app'),
  ('.xar', 'application/vnd.xara'),
  ('.xbap', 'application/x-ms-xbap'),
  ('.xbd', 'application/vnd.fujixerox.docuworks.binder'),
  ('.xbm', 'image/x-xbitmap'),
  ('.xcf', 'image/x-xcf'),
  ('.xdm', 'application/vnd.syncml.dm+xml'),
  ('.xdp', 'application/vnd.adobe.xdp+xml'),
  ('.xdw', 'application/vnd.fujixerox.docuworks'),
  ('.xenc', 'application/xenc+xml'),
  ('.xer', 'application/patch-ops-error+xml'),
  ('.xfdf', 'application/vnd.adobe.xfdf'),
  ('.xfdl', 'application/vnd.xfdl'),
  ('.xht', 'application/xhtml+xml'),
  ('.xhtml', 'application/xhtml+xml'),
  ('.xhvml', 'application/xv+xml'),
  ('.xif', 'image/vnd.xiff'),
  ('.xla', 'application/vnd.ms-excel'),
  ('.xlam', 'application/vnd.ms-excel.addin.macroenabled.12'),
  ('.xlb', 'application/vnd.ms-excel'),
  ('.xlc', 'application/vnd.ms-excel'),
  ('.xlm', 'application/vnd.ms-excel'),
  ('.xls', 'application/vnd.ms-excel'),
  ('.xlsb', 'application/vnd.ms-excel.sheet.binary.macroenabled.12'),
  ('.xlsm', 'application/vnd.ms-excel.sheet.macroenabled.12'),
  ('.xlsx', 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'),
  ('.xlt', 'application/vnd.ms-excel'),
  ('.xltm', 'application/vnd.ms-excel.template.macroenabled.12'),
  ('.xltx', 'application/vnd.openxmlformats-officedocument.spreadsheetml.template'),
  ('.xlw', 'application/vnd.ms-excel'),
  ('.xml', 'application/xml'),
  ('.xo', 'application/vnd.olpc-sugar'),
  ('.xop', 'application/xop+xml'),
  ('.xpdl', 'application/xml'),
  ('.xpi', 'application/x-xpinstall'),
  ('.xpm', 'image/x-xpixmap'),
  ('.xpr', 'application/vnd.is-xpr'),
  ('.xps', 'application/vnd.ms-xpsdocument'),
  ('.xpw', 'application/vnd.intercon.formnet'),
  ('.xpx', 'application/vnd.intercon.formnet'),
  ('.xsl', 'application/xml'),
  ('.xslt', 'application/xslt+xml'),
  ('.xsm', 'application/vnd.syncml+xml'),
  ('.xspf', 'application/xspf+xml'),
  ('.xul', 'application/vnd.mozilla.xul+xml'),
  ('.xvm', 'application/xv+xml'),
  ('.xvml', 'application/xv+xml'),
  ('.xwd', 'image/x-xwindowdump'),
  ('.xyz', 'chemical/x-xyz'),
  ('.zaz', 'application/vnd.zzazz.deck+xml'),
  ('.zip', 'application/zip'),
  ('.zir', 'application/vnd.zul'),
  ('.zirz', 'application/vnd.zul'),
  ('.zmm', 'application/vnd.handheld-entertainment+xml')
GO

-- #endregion

-- #region CauLacBo

CREATE TABLE CauLacBo(
  MaCLB char(10) NOT NULL,
  TenCLB nvarchar(50) NOT NULL,
  MoTa nvarchar(max) NOT NULL,
  AnhDaiDien varbinary(MAX) NULL,
  CONSTRAINT PK_CauLacBo PRIMARY KEY CLUSTERED (MaCLB)
)
GO
CREATE PROCEDURE CauLacBo_Them (@MaCLB char(10), @TenCLB nvarchar(50), @MoTa nvarchar(max), @AnhDaiDien varbinary(MAX) = NULL) AS BEGIN
  INSERT INTO CauLacBo(MaCLB, TenCLB, MoTa, AnhDaiDien)
  VALUES (@MaCLB, @TenCLB, @MoTa, @AnhDaiDien)
END
GO
CREATE PROCEDURE CauLacBo_DanhSach (@MaNguoiDung char(10) = NULL) AS BEGIN
  IF (@MaNguoiDung IS NULL)
    SELECT CauLacBo.MaCLB, TenCLB, MoTa, AnhDaiDien
    FROM CauLacBo
  ELSE
    SELECT CauLacBo.MaCLB, TenCLB, MoTa, AnhDaiDien
    FROM CauLacBo JOIN ThanhVien ON CauLacBo.MaCLB = ThanhVien.MaCLB
    WHERE MaNguoiDung = @MaNguoiDung
END
GO
CREATE PROCEDURE CauLacBo_TimKiem (@MaCLB char(10) = NULL, @TenCLB nvarchar(50) = NULL, @MoTa nvarchar(MAX) = NULL) AS BEGIN
  SELECT MaCLB, TenCLB, MoTa, AnhDaiDien
  FROM CauLacBo
  WHERE (@MaCLB IS NOT NULL AND MaCLB LIKE CONCAT('%', @MaCLB, '%')) OR
		(@TenCLB IS NOT NULL AND TenCLB LIKE CONCAT('%', @TenCLB, '%')) OR
		(@MoTa IS NOT NULL AND MoTa LIKE CONCAT('%', @MoTa, '%'))
END
GO
CREATE PROCEDURE CauLacBo_Sua (@MaCLB char(10), @TenCLB nvarchar(50) = NULL, @MoTa nvarchar(max) = NULL, @AnhDaiDien varbinary(MAX) = NULL) AS BEGIN
  UPDATE CauLacBo
  SET TenCLB = ISNULL(@TenCLB, TenCLB),
	  MoTa = ISNULL(@MoTa, MoTa),
	  AnhDaiDien = ISNULL(@AnhDaiDien, AnhDaiDien)
  WHERE MaCLB = @MaCLB
END
GO
CREATE PROCEDURE CauLacBo_Xoa (@MaCLB char(10)) AS BEGIN
  DELETE FROM CauLacBo WHERE MaCLB = @MaCLB
END
GO
CREATE PROCEDURE CauLacBo_ThongTin (@MaCLB char(10)) AS BEGIN
  SELECT MaCLB, TenCLB, MoTa, AnhDaiDien
  FROM CauLacBo
  WHERE MaCLB = @MaCLB
END
GO
INSERT INTO CauLacBo (MaCLB, TenCLB, MoTa, AnhDaiDien) VALUES
  ('8sDaA84CLB', N'Câu lạc bộ Tiếng Anh', N'Học tiếng Anh', (SELECT * FROM OPENROWSET(BULK 'C:\Users\User\source\repos\QuanLyCLB\hinh\avatar\artworks-ebqbJNoRi9lD4ySF-49rsMw-t500x500.jpg', SINGLE_BLOB) AS FileContent)),
  ('fa5eW5sCLB', N'Câu lạc bộ thể thao', N'Chơi thể thao nhiều nó mới vui', (SELECT * FROM OPENROWSET(BULK 'C:\Users\User\source\repos\QuanLyCLB\hinh\avatar\k46acawjk97.png', SINGLE_BLOB) AS FileContent)),
  ('w855sAsCLB', N'Câu lạc bộ văn nghệ', N'Đại loại là lên sân khấu hát hò, nhảy múa, kiểu vậy...', (SELECT * FROM OPENROWSET(BULK 'C:\Users\User\source\repos\QuanLyCLB\hinh\avatar\k46acawjk97.png', SINGLE_BLOB) AS FileContent)),
  ('6sa6cW4CLB', N'Câu lạc bộ Công nghệ thông tin', N'Xây dựng các giải pháp phần mềm và sử dụng các phần mềm văn phòng', NULL)
GO

-- #endregion

-- #region ThuMuc

CREATE TABLE ThuMuc (
  MaThuMuc char(10) NOT NULL,
  TenThuMuc nvarchar(255) NOT NULL,
  MaMau int NOT NULL,
  MaCLB char(10) NOT NULL,
  ThuMucGoc bit NOT NULL DEFAULT 0, /* Mỗi CLB luôn có 1 thư mục gốc, có thể tuỳ chỉnh nhưng không thể xoá. Khi xoá một thư mục nào đó, tất cả các file sẽ nằm ở đây */
  CONSTRAINT PK_ThuMuc PRIMARY KEY CLUSTERED (MaThuMuc),
  CONSTRAINT FK_ThuMuc_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB),
)
GO
CREATE PROCEDURE ThuMuc_ThongTin (@MaThuMuc char(10)) AS BEGIN
  SELECT ThuMuc.MaThuMuc, ThuMuc.TenThuMuc, ThuMuc.MaMau, ThuMuc.MaCLB, ThuMuc.ThuMucGoc, COUNT(TapTin.MaTapTin) AS SoLuongFile
  FROM ThuMuc LEFT JOIN TapTin ON ThuMuc.MaThuMuc = TapTin.MaThuMuc
  WHERE ThuMuc.MaThuMuc = @MaThuMuc
  GROUP BY ThuMuc.MaThuMuc, ThuMuc.TenThuMuc, ThuMuc.MaMau, ThuMuc.MaCLB, ThuMuc.ThuMucGoc
END
GO
CREATE PROCEDURE ThuMuc_DanhSach (@MaCLB char(10)) AS BEGIN
  SELECT ThuMuc.MaThuMuc, ThuMuc.TenThuMuc, ThuMuc.MaMau, ThuMuc.MaCLB, ThuMuc.ThuMucGoc, COUNT(TapTin.MaTapTin) AS SoLuongFile
  FROM ThuMuc JOIN CauLacBo ON ThuMuc.MaCLB = CauLacBo.MaCLB
              LEFT JOIN TapTin ON ThuMuc.MaThuMuc = TapTin.MaThuMuc
  WHERE CauLacBo.MaCLB = @MaCLB
  GROUP BY ThuMuc.MaThuMuc, ThuMuc.TenThuMuc, ThuMuc.MaMau, ThuMuc.MaCLB, ThuMuc.ThuMucGoc
END
GO
CREATE PROCEDURE ThuMuc_Them (
  @MaThuMuc char(10),
  @TenThuMuc nvarchar(255),
  @MaMau int,
  @MaCLB char(10)
) AS BEGIN
  INSERT INTO ThuMuc (MaThuMuc, TenThuMuc, MaMau, MaCLB)
  VALUES (@MaThuMuc, @TenThuMuc, @MaMau, @MaCLB)
END
GO
CREATE PROCEDURE ThuMuc_Sua (
  @MaThuMuc char(10),
  @TenThuMuc nvarchar(255) = NULL,
  @MaMau int = NULL,
  @MaCLB char(10) = NULL
) AS BEGIN
  UPDATE ThuMuc
  SET TenThuMuc = ISNULL(@TenThuMuc, TenThuMuc),
	  MaMau = ISNULL(@MaMau, @MaMau),
	  MaCLB = ISNULL(@MaCLB, MaCLB)
  WHERE MaThuMuc = @MaThuMuc
END
GO
CREATE PROCEDURE ThuMuc_Xoa (
  @MaThuMuc char(10),
  @MaThuMucGoc char(10)
) AS BEGIN
  BEGIN TRANSACTION
    UPDATE TapTin SET MaThuMuc = @MaThuMucGoc WHERE MaThuMuc = @MaThuMuc
    DELETE FROM ThuMuc WHERE MaThuMuc = @MaThuMuc
  COMMIT TRANSACTION
END
GO
INSERT INTO ThuMuc(MaThuMuc, TenThuMuc, MaMau, MaCLB, ThuMucGoc) VALUES
  ('CM8n5RhSZP', N'Speaking Day', 0x156158, '8sDaA84CLB', 1),
  ('Sq4hOn7GCP', N'Sunday Storyteller', 0x4a8b9ca, '8sDaA84CLB', 0),
  ('rGJs6pvkHP', N'Thi cử tạ', 0xa6b16cc, 'fa5eW5sCLB', 1),
  ('QTbD04nLOP', N'Thi Olympic', 0x88debf, 'fa5eW5sCLB', 0),
  ('6tgJjL5UCP', N'Gặp nhau cuối tuần', 0xa56bcd, 'w855sAsCLB', 0),
  ('tnDFurb4SP', N'Giọng hát vàng', 0x88fabe, 'w855sAsCLB', 1),
  ('cUL1QuSY7P', N'Lập trình Java', 0xdabe8c, '6sa6cW4CLB', 0),
  ('znF1AZt76P', N'Office', 0xaab48e, '6sa6cW4CLB', 0),
  ('MCdurdLzGP', N'Cắt ghép', 0x889abd, '6sa6cW4CLB', 0),
  ('61ASJadf6P', N'Khác', 0x18aabd, '6sa6cW4CLB', 1)
GO

-- #endregion

-- #region TapTin

CREATE TABLE TapTin(
  MaTapTin uniqueidentifier ROWGUIDCOL NOT NULL,
  TenTapTin nvarchar(255) NOT NULL,
  NoiDung varbinary(max) FILESTREAM NOT NULL,
  ThoiGianTao datetime NOT NULL,
  ThoiGianSuaDoi datetime NOT NULL,
  ThoiGianTruyCap datetime NOT NULL,
  PhanMoRong AS COALESCE(LOWER(CASE WHEN TenTapTin LIKE '%.%' THEN '.' + REVERSE(LEFT(REVERSE(TenTapTin), CHARINDEX('.', REVERSE(TenTapTin)) - 1)) ELSE '' END), ''),
  MimeType AS COALESCE(dbo.GetMimeType(LOWER(CASE WHEN TenTapTin LIKE '%.%' THEN '.' + REVERSE(LEFT(REVERSE(TenTapTin), CHARINDEX('.', REVERSE(TenTapTin)) - 1)) ELSE '' END)), 'application/octet-stream'),
  DungLuong AS DATALENGTH(NoiDung),
  MaThuMuc char(10) NOT NULL,
  CONSTRAINT PK_TapTin PRIMARY KEY CLUSTERED (MaTapTin),
  CONSTRAINT FK_TapTin_ThuMuc FOREIGN KEY (MaThuMuc) REFERENCES ThuMuc (MaThuMuc)
)
GO
CREATE PROCEDURE TapTin_ThongTin (@MaTapTin uniqueidentifier) AS BEGIN
  SELECT TapTin.MaTapTin, TapTin.TenTapTin, TapTin.ThoiGianTao, TapTin.ThoiGianSuaDoi, TapTin.ThoiGianTruyCap, TapTin.PhanMoRong, TapTin.MimeType, TapTin.DungLuong,
         ThuMuc.MaThuMuc, ThuMuc.TenThuMuc, TapTin.NoiDung -- Để cuối để stream ko bị dispose khi query theo cách SequentialAccess
  FROM TapTin JOIN ThuMuc ON TapTin.MaThuMuc = ThuMuc.MaThuMuc
  WHERE MaTapTin = @MaTapTin
END
GO
CREATE PROCEDURE TapTin_DanhSach (@MaThuMuc char(10)) AS BEGIN
  SELECT MaTapTin, TenTapTin, ThoiGianTao, ThoiGianSuaDoi, ThoiGianTruyCap, PhanMoRong, MimeType, DungLuong,
         MaThuMuc, NoiDung -- Để cuối để stream ko bị dispose khi query theo cách SequentialAccess
  FROM TapTin
  WHERE MaThuMuc = @MaThuMuc
  ORDER BY LOWER(TenTapTin) ASC
END
GO
CREATE PROCEDURE TapTin_Them (
  @MaTapTin uniqueidentifier,
  @TenTapTin nvarchar(255),
  @NoiDung varbinary(max),
  @ThoiGianTao datetime,
  @ThoiGianSuaDoi datetime,
  @ThoiGianTruyCap datetime,
  @MaThuMuc char(10)
) AS BEGIN
  INSERT INTO TapTin (MaTapTin, TenTapTin, NoiDung, ThoiGianTao, ThoiGianSuaDoi, ThoiGianTruyCap, MaThuMuc)
  VALUES (@MaTapTin, @TenTapTin, @NoiDung, @ThoiGianTao, @ThoiGianSuaDoi, @ThoiGianTruyCap, @MaThuMuc)
END
GO
CREATE PROCEDURE TapTin_DoiTen (
  @MaTapTin uniqueidentifier,
  @TenTapTin nvarchar(255)
) AS BEGIN
  UPDATE TapTin SET TenTapTin = @TenTapTin
  WHERE MaTapTin = @MaTapTin
END
GO
CREATE PROCEDURE TapTin_Sua (
  @MaTapTin uniqueidentifier,
  @TenTapTin nvarchar(255) = NULL,
  @ThoiGianTao datetime = NULL,
  @ThoiGianSuaDoi datetime = NULL
) AS BEGIN
  UPDATE TapTin
  SET TenTapTin = ISNULL(@TenTapTin, TenTapTin),
      ThoiGianTao = ISNULL(@ThoiGianTao, ThoiGianTao),
	  ThoiGianSuaDoi = ISNULL(@ThoiGianSuaDoi, ThoiGianSuaDoi)
  WHERE MaTapTin = @MaTapTin
END
GO
CREATE PROCEDURE TapTin_DiChuyen (
  @MaTapTin uniqueidentifier,
  @MaThuMuc char(10)
) AS BEGIN
  UPDATE TapTin SET MaThuMuc = @MaThuMuc
  WHERE MaTapTin = @MaTapTin
END
GO
CREATE PROCEDURE TapTin_SaoChep (
  @MaTapTin uniqueidentifier,
  @MaTapTinMoi uniqueidentifier,
  @MaThuMuc char(10)
) AS BEGIN
  INSERT INTO TapTin (MaTapTin, TenTapTin, NoiDung, ThoiGianTao, ThoiGianSuaDoi, ThoiGianTruyCap, MaThuMuc)
  SELECT @MaTapTinMoi, TapTin.TenTapTin, TapTin.NoiDung, TapTin.ThoiGianTao, TapTin.ThoiGianSuaDoi, TapTin.ThoiGianTruyCap, @MaThuMuc
  FROM TapTin
  WHERE MaTapTin = @MaTapTin
END
GO
CREATE PROCEDURE TapTin_Xoa (
  @MaTapTin uniqueidentifier
) AS BEGIN
  DELETE FROM TapTin WHERE MaTapTin = @MaTapTin
END
GO

-- #endregion

-- #region NguoiDung

CREATE TABLE NguoiDung(
  MaNguoiDung char(10) NOT NULL,
  Ho nvarchar(50) NOT NULL,
  Lot nvarchar(50) NOT NULL,
  Ten nvarchar(50) NOT NULL,
  SDT varchar(15) NOT NULL,
  GioiTinh bit NOT NULL,
  NgaySinh date NOT NULL,
  Email nvarchar(255) NOT NULL,
  MSSV varchar(15) NOT NULL,
  MaQuyenHan varchar(10) NOT NULL DEFAULT 'Q-User',
  TenDangNhap varchar(255) NOT NULL UNIQUE,
  MatKhau nvarchar(255) NOT NULL,
  MaBaoMat varchar(255) NOT NULL,
  AnhDaiDien varbinary(MAX) DEFAULT NULL,
  ThoiGianTao datetime NOT NULL DEFAULT GetDate(), /* không báo các thông báo cũ */
  Duyet tinyint NOT NULL DEFAULT 0, /* 0: chưa được duyệt, 1: đã được duyệt, 2: không có cửa */
  CONSTRAINT PK_NguoiDung PRIMARY KEY CLUSTERED (MaNguoiDung),
  CONSTRAINT FK_NguoiDung_QuyenHan FOREIGN KEY (MaQuyenHan) REFERENCES QuyenHan (MaQuyenHan),
  CONSTRAINT CK_NguoiDung_SDT CHECK ((
    SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or
    SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]' or
    SDT LIKE '0[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
  CONSTRAINT CK_NguoiDung_Email CHECK ((Email LIKE '_%@_%._%'))
)
GO
CREATE FUNCTION NguoiDung_MaHoa(@TenDangNhap varchar(255), @MatKhau nvarchar(255), @MaBaoMat varchar(255)) RETURNS char(64) AS BEGIN
  RETURN LOWER(CONVERT(
    nvarchar(max),
    HASHBYTES('SHA2_256', @MatKhau + @TenDangNhap + @MaBaoMat),
    2
  ))
END
GO
CREATE PROCEDURE NguoiDung_DangNhap(@TenDangNhap varchar(255), @MatKhau nvarchar(255)) AS BEGIN
  SELECT *
  FROM NguoiDung
  WHERE TenDangNhap = @TenDangNhap AND
    dbo.NguoiDung_MaHoa(@TenDangNhap, @MatKhau, MaBaoMat) = MatKhau
END
GO
CREATE PROCEDURE NguoiDung_TimKiem(
  @MaNguoiDung char(10) = NULL, @Ho nvarchar(50) = NULL, @Lot nvarchar(50) = NULL, @Ten nvarchar(50) = NULL, @MaQuyenHan varchar(10) = NULL,
  @SDT varchar(15) = NULL, @GioiTinh bit = NULL, @NgaySinh date = NULL, @Email nvarchar(255) = NULL, @MSSV varchar(15) = NULL,
  @TenDangNhap varchar(255) = NULL, @Duyet int = NULL) AS BEGIN
  SELECT TOP 20 MaNguoiDung, Ho, Lot, Ten, NguoiDung.MaQuyenHan, TenQuyenHan, AnhDaiDien, GioiTinh, Email, NgaySinh, SDT, MSSV, ThoiGianTao, Duyet, TenDangNhap
  FROM NguoiDung JOIN QuyenHan ON NguoiDung.MaQuyenHan = QuyenHan.MaQuyenHan
  WHERE (@MaNguoiDung IS NOT NULL AND MaNguoiDung LIKE CONCAT('%', @MaNguoiDung, '%')) OR
    (@Ho IS NOT NULL AND Ho LIKE CONCAT('%', @Ho, '%')) OR
    (@Lot IS NOT NULL AND Lot LIKE CONCAT('%', @Lot, '%')) OR
    (@Ten IS NOT NULL AND Ten LIKE CONCAT('%', @Ten, '%')) OR
    (@SDT IS NOT NULL AND SDT LIKE CONCAT('%', @SDT, '%')) OR
    (@GioiTinh IS NOT NULL AND GioiTinh = @GioiTinh) OR
    (@NgaySinh IS NOT NULL AND NgaySinh = @NgaySinh) OR
    (@MaQuyenHan IS NOT NULL AND NguoiDung.MaQuyenHan = @MaQuyenHan) OR
    (@Email IS NOT NULL AND Email LIKE CONCAT('%', @Email, '%')) OR
    (@MSSV IS NOT NULL AND MSSV LIKE CONCAT('%', @MSSV, '%')) OR
    (@TenDangNhap IS NOT NULL AND TenDangNhap LIKE CONCAT('%', @TenDangNhap, '%')) OR
    (@Duyet IS NOT NULL AND Duyet = @Duyet)
END
GO
CREATE PROCEDURE NguoiDung_Them (
  @MaNguoiDung char(10), @Ho nvarchar(50), @Lot nvarchar(50), @Ten nvarchar(50),
  @SDT varchar(15), @GioiTinh bit, @NgaySinh date, @Email nvarchar(255), @MSSV varchar(15),
  @TenDangNhap varchar(255), @MatKhau nvarchar(255), @MaBaoMat varchar(255), @AnhDaiDien varbinary(MAX) = NULL
) AS BEGIN
  INSERT INTO NguoiDung (MaNguoiDung, Ho, Lot, Ten, SDT, GioiTinh, NgaySinh, Email, MSSV, TenDangNhap, MatKhau, MaBaoMat, AnhDaiDien)
  VALUES (@MaNguoiDung, @Ho, @Lot, @Ten, @SDT, @GioiTinh, @NgaySinh, @Email, @MSSV, @TenDangNhap, @MatKhau, @MaBaoMat, @AnhDaiDien)
END
GO
CREATE PROCEDURE NguoiDung_Xoa (
  @MaNguoiDung char(10)
) AS BEGIN
  DELETE FROM NguoiDung
  WHERE MaNguoiDung = @MaNguoiDung
END
GO
CREATE PROCEDURE NguoiDung_Sua (
  @MaNguoiDung char(10), @Ho nvarchar(50) = NULL, @Lot nvarchar(50) = NULL, @Ten nvarchar(50) = NULL,
  @SDT varchar(15) = NULL, @GioiTinh bit = NULL, @NgaySinh date = NULL, @Email nvarchar(255) = NULL, @MSSV varchar(15) = NULL, @MaQuyenHan varchar(10) = NULL,
  @TenDangNhap varchar(255) = NULL, @MatKhau nvarchar(255) = NULL, @MaBaoMat varchar(255) = NULL, @AnhDaiDien varbinary(MAX) = NULL, @Duyet tinyint = NULL
) AS BEGIN
  UPDATE NguoiDung SET
    Ho = ISNULL(@Ho, Ho),
    Lot = ISNULL(@Lot, Lot),
    Ten = ISNULL(@Ten, Ten),
    SDT = ISNULL(@SDT, SDT),
    GioiTinh = ISNULL(@GioiTinh, GioiTinh),
    NgaySinh = ISNULL(@NgaySinh, NgaySinh),
    Email = ISNULL(@Email, Email),
    MSSV = ISNULL(@MSSV, MSSV),
    MaQuyenHan = ISNULL(@MaQuyenHan, MaQuyenHan),
    TenDangNhap = ISNULL(@TenDangNhap, TenDangNhap),
    MatKhau = ISNULL(@MatKhau, MatKhau),
    MaBaoMat = ISNULL(@MaBaoMat, MaBaoMat),
    AnhDaiDien = ISNULL(@AnhDaiDien, AnhDaiDien),
	Duyet = ISNULL(@Duyet, Duyet)
  WHERE MaNguoiDung = @MaNguoiDung
END
GO
CREATE PROCEDURE NguoiDung_ThongTin(@MaNguoiDung char(10)) AS BEGIN
  SELECT MaNguoiDung, Ho, Lot, Ten, NguoiDung.MaQuyenHan, TenQuyenHan, AnhDaiDien, GioiTinh, Email, NgaySinh, SDT, MSSV, ThoiGianTao, TenDangNhap
  FROM NguoiDung JOIN QuyenHan ON NguoiDung.MaQuyenHan = QuyenHan.MaQuyenHan
  WHERE MaNguoiDung = @MaNguoiDung
END
GO
INSERT INTO NguoiDung (MaNguoiDung, Ho, Lot, Ten, SDT, GioiTinh, NgaySinh, Email, MSSV, TenDangNhap, MatKhau, MaBaoMat, ThoiGianTao, Duyet) values
  ('IxbBG93Z0U', 'Silverton', '', 'Melva', '0168961949', 1, '1994-07-17', 'msilverton0@multiply.com', '933301148298', 'tk1', '0a9961ee55958aee5bf1ad946015faabaebbc7f20c31b8ca9e43e1e9268583bf', 'H072SPHGQRLE4E0oVGBVYqNhLzvxfxy8j/U7L1Rl+J8AKrOMyD/w2J4IkY3SR53/19rKK5g0J2RivnIJJclCNw==', '2024-07-26', 1),                              /* Pass: Finland */
  ('bYVbR3IgUU', 'Danbury', '', 'Josy', '0711848065', 1, '1996-06-14', 'jdanbury1@mysql.com', '295063734874', 'tk2', '7dbceb4c0410f19b388dd5f8b297c574c0af4863ae51c0aeed8b884cbe078f9f', 'Ql8FWmq43Pm57E7g1ZzVOjQQYyf3eKEm1mLcLoJnY/RF+hQ/QsnYQI1GrWSZrb59/nbT8Ln2Q6RoqGVhdX6qgQ==', '2015-09-02', 1),                                      /* Pass: Indonesia */
  ('5U9YMtOMmU', 'Prettyman', '', 'Archibald', '042402245', 1, '2001-03-26', 'aprettyman2@huffingtonpost.com', '153407258724', 'tk3', 'b8072544d0ab0591c005c83a702a609d1039f4a0ece0891238e9e813105ec5fc', 'emOUdJtrquSjKv91GnhXaB1fzQ88LuqXHP129S5inBNX78hhbXIgESpSZLYlj+C47Yi916tCh6+StCRh42/Uhw==', '2016-02-20', 1),                     /* Pass: Mexico */
  ('GPkIyyqSzU', 'Guiden', '', 'Haleigh', '09727141388', 1, '1998-04-26', 'hguiden3@discovery.com', '392938317787', 'tk4', '54aa1bf89b0a1a1e6e19eb6bc169c8afb7477b322668f5ff7f5928283edde3d1', 'keWYd9c7IV5/FuHByYx+uLYkxRH/UnywMkStw258KiXgHzsoxd+x7WX8OVkSsZm/RhNgyRfbJB7X+px07appMQ==', '2021-10-16', 1),                                /* Pass: Peru */
  ('Zn5y0UhMoU', 'Bethune', 'Nico', 'Byram', '0393682203', 1, '1999-12-18', 'bbethune4@youtube.com', '785297491548', 'tr2', '9aa6ae9c85664a6e811e2bb9ff636770bb4cc995919a2b5060ff50a0fa3a58f6', 'rtA0mtdpz3PLjQZflaABoLjvCQsSQjbOQ9vA/LH3HDq0zLUGhlnttiDIjfzlgSsA7ra0ZPHjUO6rCV0KhL+QdA==', '2015-03-06', 1),                               /* Pass: Indonesia */
  ('7HRgDGyZAU', 'D''Adda', 'Husein', 'Dwain', '0050873132', 0, '1996-09-19', 'ddadda5@newyorker.com', '047446543102', 'tk6', '61e18868a354d0883546e2703dd5a6b1b03f287bc5239765501d8dcc6a4da3e1', 'wLfYS9B7MaSgPbBT7rpxUoXq25ygGR/A5EifMU6MhQGfp5lfGXYdbU2xY+UE17qP7WgB3zpnhu9Mx/n9llFxFA==', '2012-09-18', 1),                             /* Pass: Russia */
  ('q6tsLjzUiU', 'World', 'Thaine', 'Maggee', '0040114240', 0, '2006-02-18', 'mworld6@theatlantic.com', '375500399324', 'tk7', '7470d2c9d5ba82cd6658fcd6be55a009e1d532260ba4e969d1b4e032f88a4507', '0NVZeYjUkNStSqTBbg0lBFBmwGYFsT/D6lvKFWFbfBppxMGz93kRorfJi18+ohQbDCQF0O/0amTM8Cl+YFM3xQ==', '2012-11-08', 2),                            /* Pass: Poland */
  ('Ao7AwPO7NU', 'Kosel', 'Farr', 'Sergio', '07363744976', 0, '1991-08-08', 'skosel7@patch.com', '623037964183', 'tr1', '28e7841160178da6b91b631ca12ac17b085b58de0ecf56bc5bf0ea63f715d0e9', 'KYi+o3JgkM/1cunQIBcb7qEGBg35rkGvNmzAAz0h6fGE8Vv6CnNJTggDgvfALl8bPf+fLHlV2vwMdosrZJlurw==', '2024-02-10', 1),                                   /* Pass: Russia */
  ('xaRkcALmUU', 'Gristwood', 'Damaris', 'Rocky', '0764910218', 0, '1991-12-15', 'rgristwood8@sogou.com', '905125933640', 'tk9', '845c0e9582f8c672560f9700fb35711aab184c5eb94bebca480a95ce3403dfa8', 'RitzENtUP8lEIQ1dqaSI5pvFsOVkkEM9HdMXZJTSHV4Ew7gV3wKKXtXgSEORkRsyewA+jbtASlUjiXZQJUasPA==', '2022-06-13', 1),                          /* Pass: Philippines */
  ('mdmxOBEVhU', 'Allwright', '', 'Austin', '09519473258', 1, '1998-09-28', 'aallwright9@flickr.com', '737752255447', 'tk10', 'bf627571c7efa7b07f4f44775fdf427caea5a73c653e4cc70321cd0e9db62fb4', 'IqnVawvHGE7CDDN/RDSSuzQ03Xsz8f/NxGzSke1qsV6LJJIRi5ijCRHNpycqi5nDR66qGx27Pbvz9SeSQEOaPw==', '2012-05-20', 1),                             /* Pass: Senegal */
  ('b8EsFmarDU', 'Shewon', 'Reggie', 'Payton', '04596457014', 0, '1993-01-11', 'pshewona@narod.ru', '171202873810', 'ph4', 'e4b153649790b818a9531e1d9d4ff7a4a0f8ffccdaaaf5a8def6a477b0d81b9c', 'ZcZ3JF474RrxAU/aydaC6ZphkL91xyJBRoZ8cdfFrmVJnllU3i5hyyzjt2py1mfg0AZ1m22/JRGTxiu2aALzZw==', '2020-02-04', 1),                                /* Pass: China */
  ('tw8PUeQgSU', 'Elstub', 'Hetty', 'Izabel', '013776182', 1, '1997-07-16', 'ielstubb@slashdot.org', '297369873600', 'tk11', '608acd492d7b368f872d95e3105d27ac9a395f70892c58bb234ca9fe10bb96bd', 'wP6/22QIcwkiRbgUS62v0kv0lFPg1kF9ER3g6ipB0x+SlS5xYn4RV9Eip/o2ti2kTN5N3vX4PXg6AKo/P4UTBw==', '2009-12-27', 1),                              /* Pass: Armenia */
  ('EDsE3oLIGU', 'Sanders', '', 'Holmes', '09058243665', 1, '1993-04-24', 'hsandersc@bloglines.com', '803564992632', 'tk12', 'b57afe1afbffa67d288a55a24eaf587ef660201cf92d914b8a8d8a3cdaf984c8', 'JACDoty7ijOAzhu/8XuKLAIITPIV9SxywaH0tR+r56XbjegbMGLTcGqPQf0PvheHkv4CEmFya6V1DcQmYbDuSA==', '2010-10-07', 1),                              /* Pass: China */
  ('vcjH9vf2ZU', 'Spark', 'Dorthy', 'Taddeo', '0200212022', 0, '1997-10-24', 'tsparkd@theguardian.com', '895640252282', 'tk13', 'cced74ce2bfc68cbb415fdb9e2384e04a00ca57b3199da871a2475170810dc2e', 's6NvqxqDR20y3PvqrUQHas5ogFE7ogake0qiN5VpC/2ROsv3mxHLsqJYRJOxQcNNHwsDS0m5HzEl7LVtfl5iAA==', '2013-05-15', 1),                           /* Pass: Russia */
  ('K3hMg4a10U', 'Nerval', '', 'Geralda', '00925328336', 1, '1993-09-28', 'gnervale@live.com', '044024530374', 'tk14', '0c71fde59ef328ef298856e29b7a6363baf148bf9b67b06431d7249951c38a9f', 'R36Ifm9hfLEC8vZPonBzMHGYDhPIpDxD2Ly5d5BA8HD6LnmZlIzaKMMkUdwAN99Rav1VCDAnWCSfkVJh9iwwbg==', '2021-02-09', 1),                                    /* Pass: Sweden */
  ('jmAHTSj5cU', 'Hurcombe', 'Simone', 'Reuben', '0953492243', 1, '1997-04-16', 'rhurcombef@cyberchimps.com', '100997013351', 'tk15', 'e66bf8508daddfe5ee9f9bb21534e9ed96ec66a5366ac65cc21d05e7745d73b0', 'NuZHoopNvml7g9GlDaQDeNpvLZx4eM/6HptCaTTs+5bzmLKHAy61Hcrz9metJqjEtwXoWC+qownXa1nIcouCIg==', '2010-03-28', 1),                     /* Pass: China */
  ('EGGfmv3WPU', 'Setford', '', 'Ashlee', '085280938', 1, '1998-10-24', 'asetfordg@wikia.com', '031835259302', 'tk16', '7d2eca98783bbf700d014b432f50adb1c4f3d68a0ad010929ed9ab0de783207c', 'pLhMBUGgMWRm11lMbz+A32jCj+jIpTSybpPFTh5TuNu2WDmg7/BOUvu4nvuJh5NXbHwUwK2Nixw1SraNC4snHw==', '2016-04-04', 1),                                    /* Pass: Mali */
  ('2ztE5oVI0U', 'Lundbeck', 'Federico', 'Samuele', '025892853', 1, '2003-05-25', 'slundbeckh@buzzfeed.com', '210559521464', 'tk17', '11447941888cbf94782275c7f6bc3c3f9477cc214e915ff4f8d0cd1a3cfc8791', '62AYRxRhl93Ehj7U49bjXx1Fk0Xx0Hl26ZXWBMdzN4MzMspVV6yBDZ5GrRn22H4cI+IPTqgBzXk7KUHTEnxfkw==', '2015-04-06', 1),                      /* Pass: Mexico */
  ('EW6L7L1IHU', 'Hourston', 'Aprilette', 'West', '0326703178', 1, '1991-04-21', 'whourstoni@mashable.com', '063771688475', 'tk18', 'c524dec10934499613260d2e4f9c7193c5bdc47b27142c0a36f4de5fbb658a4d', '5fHy+AYnIT+13O/9/Y2RVADDZVIxcEY/+depJpP6v5bidTIZFkXdHirs1isu2ZVm2+ujyG8BsMzCaLGOpdrf2g==', '2024-08-24', 1),                       /* Pass: Indonesia */
  ('Tb7sFvW2sU', 'Olsen', 'Rafaelita', 'Fidelia', '099388259', 0, '1993-06-14', 'folsenj@google.nl', '659913439158', 'tk19', '82b0b6d23f83e740216922afabcd1a291af4f900ff92b195f54251d04e155e3f', 'Lj1b6ii1WgNYrN2zGeLGKXG9ULh8ATgWJ/a1q4Rfi1+s/fHKvkyEKX9qqCQflaDWV220PX+W0+VzDjnep5ALfA==', '2020-03-27', 1),                              /* Pass: China */
  ('p6vHgIjbeU', 'Geaney', 'Perla', 'Elora', '068672274', 0, '1996-03-22', 'egeaneyk@unc.edu', '848720788596', 'tk20', 'e1bfd3f4a0fa54f1136e5d45c3cec008f0482b66147770a8181558f1ddb76aa1', '+54vPP/HxBqzWwlaRnSXHKwdw8SMXpdQrkAk2zYUH4fF0x9C0G5TUrV/pMK7Zf4aqipg+fovb8AnRg9eIq+x5A==', '2023-08-13', 1),                                    /* Pass: Argentina */
  ('RGJ8YZdM8U', 'Barhem', '', 'Tyson', '0118581480', 1, '2001-01-23', 'tbarheml@nbcnews.com', '141828559744', 'tk21', '3d0cec0e4d824422cdb0666e8f0984bb256942fb7deaf87f793068335a6193b1', 'qBeWGbTygqJ2wQFTiq38r4RsCXvjT48A+2WE7CUyRJXVf49NuUhLQLO0pNi4wla47A7wjmsXSMAFHsDii3kLWA==', '2023-05-18', 1),                                    /* Pass: Costa Rica */
  ('BPtDufvxiU', 'Van Der Straaten', '', 'Meade', '060993498', 0, '1992-02-23', 'mvanderstraatenm@scribd.com', '329340353382', 'tk22', '755f6e9129a7e7619977e57ac90613b8dfd5392eb9d624d2dd09b96085692490', 'a/F/j1P4TWbxw7lQdTM1ToSWV622vFLC6Ea+P3t7D3IVBaAGzLdTcrqjLKARcwgC03zGPV5WmjbcI3Q8q9ftKQ==', '2015-04-19', 1),                    /* Pass: Lebanon */
  ('S1RGybkGKU', 'Wilfing', 'Tanny', 'Hanny', '00293481004', 1, '1993-06-10', 'hwilfingn@mapquest.com', '249071410969', 'ph3', '1c2c3e6850f3597ad5bffaad893a02866ee961fe501c2f6f0e9bcd0b9c674eaa', '2Fd1INB9EpTiWAyqh28ffITqdT1qYfu41LGUuhFdXSj1C6JVN0Y1CUZr+airpneoie6EIqF98si9HFAGxHYHcQ==', '2008-12-13', 1),                            /* Pass: Italy */
  ('CDLoby6vYU', 'Imms', 'Derk', 'Levon', '043511536', 1, '1996-11-28', 'limmso@mediafire.com', '732913099764', 'tk24', '701eb75950d0cfeccb1b52b108e9016d84e45e54e8dc655fdfaaa82ac7a2e4c7', 'W6cU5cpmQ4lVQxb1nwii+vpwFxKZtwaCnmt4F8GASpvzybn/bVbRGEOV1C9VIsbje8zsrE5LmIZJhqyp2u94NQ==', '2012-08-28', 1),                                   /* Pass: China */
  ('QoAT4ZaIYU', 'Albrooke', '', 'Reginauld', '09104583858', 0, '2002-12-05', 'ralbrookep@toplist.cz', '445687237730', 'tk25', 'ea3ed9f1be32c2629d877102bc072dd09b7b1b452cd40357a91e63d243292e50', 'dw8PrX1d8fFbdFgN6lJO6+7EhMIHbsTup69XkoA7GSEv0reb5LKJXYb1HN3vT5nzlXhG39BdkZr6/YG1YlqneA==', '2016-09-16', 1),                            /* Pass: Albania */
  ('nDhR3X8MhU', 'Lattin', '', 'Kilian', '0052276854', 0, '2004-06-05', 'klattinq@un.org', '216073627255', 'tk26', '11f63787daa5dbcc2e1f26f10dee492588375fd24119f247a6ad0b574b9d2432', 'IRdECcAstuvViNE1sLyuBAg4OPXI+/rOk8jniSPLXvnNcUXFAL0o9QoHvx++sfs+Hs989CwOvRWOiop1ZtmO/w==', '2021-01-29', 1),                                        /* Pass: Israel */
  ('3A0NGVbgvU', 'Watsham', '', 'Lucita', '086167858', 1, '1995-08-28', 'lwatshamr@linkedin.com', '590466714689', 'tk27', '1d27d0aa1c87e7eaa8ad877747264996063db4cf3e8af1927b79b0b85a21b58e', 'NvgNagjHjeBixTo0NkZu/3PNcHUIUt0MiTLltegwN5BavKNEPMrPm96xiz6k9PAQ9Ym8Q467C16OB5UAQbHAIg==', '2024-10-15', 1),                                 /* Pass: Portugal */
  ('j8RxtB6WbU', 'Piller', '', 'Sebastian', '0483868674', 1, '2006-08-06', 'spillers@vk.com', '863531154911', 'tk28', 'ca596286d80b040898ed122475502ca50cb58cc9fe218d510415495c6b3ccfdf', '8S+c+x5wNCI67+cv+o7nfxE+vB3tCmIjZJxpK9SVDRcAUpEHv7Gq+asZwKeeEoSwAQKQmilcf1kA9K4dVqTDRg==', '2024-03-24', 1),                                     /* Pass: Mayotte */
  ('3hl381IaYU', 'Craisford', 'Elicia', 'Efren', '0158533879', 0, '1997-04-07', 'ecraisfordt@themeforest.net', '452390198677', 'tk29', '60ee4dcb5949b27ef7989f0a4e524ce82b2326d1f6a23d76082a17551cdc62f1', 'I7SsBw3SnYkUG9LgH/NSz/89scD+LTbk69OomauuEtHADMMW9EIdJwBN8mV3KjzAgOouEnUc3euBarGfsZveGA==', '2015-02-23', 1),                    /* Pass: Colombia */
  ('xEub1JcMpU', 'Knoble', 'Josy', 'Rasia', '035890702', 1, '1997-08-14', 'rknobleu@biblegateway.com', '579960940600', 'ph2', '86227d823b6fa93eb4aa8408ec33d70ef5b7c3922cc1e67c74046f6bdb19fa9b', 'p49QLCGsXZHZ7/3uHyCSejzmjZjXrccLUb+xhe+4Run7Y6BqmJJZCCkqMG1prYgl1JWCKWOzY45LoggyT119lQ==', '2008-03-28', 1),                             /* Pass: Indonesia */
  ('O21btKjcBU', 'Corey', '', 'Lorilee', '0751216742', 0, '1994-12-26', 'lcoreyv@pbs.org', '006180205546', 'ph32', 'd4fbf747790e0379fd05d96c1e4a722c555c8eb8a7fe3c037aa09194b0311407', '5O3XIhaAOnIBkcCXvX9cBSEf4OpKRry+sFtFcNU7duSsqoj8VoDLZpFGuetisei5yBkkhGov4E6c2mdeBLI9+Q==', '2014-11-25', 1),                                        /* Pass: Syria */
  ('HeMGZxVnaU', 'Dumphy', 'Lesly', 'Roman', '03161891002', 0, '1995-03-08', 'rdumphyw@google.co.jp', '053989017015', 'tk30', 'a84d94d9c3fa3b3916c89b935bfe931a67003ed27c26170ce63d2a37b50d9668', 'Q2etS0Tcx1+gDHjJZ9vJMLw3++h2LfeOE3cjwug+L3ps/CtQ5XyezzWQGtTDGrVP6cdO77hYVoyrXU0mt876Qg==', '2007-09-25', 1)                              /* Pass: Peru */
GO

UPDATE NguoiDung SET MaQuyenHan = 'Q-Admin' WHERE MaNguoiDung = 'IxbBG93Z0U'

-- #endregion

-- #region DuongLinkCauLacBo

CREATE TABLE DuongLinkCauLacBo(
  MaCLB char(10) NOT NULL,
  MaLienKet int NOT NULL IDENTITY(1,1),
  NenTang nvarchar(50) NOT NULL,
  DuongLienKet nvarchar(MAX) NOT NULL,
  CONSTRAINT PK_DuongLinkCauLacBo PRIMARY KEY CLUSTERED (MaCLB, MaLienKet),
  CONSTRAINT FK_DuongLinkCauLacBo_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB)
)
GO
CREATE PROCEDURE DuongLinkCauLacBo_DanhSach(@MaCLB char(10) = NULL) AS BEGIN
  SELECT MaCLB, MaLienKet, NenTang, DuongLienKet
  FROM DuongLinkCauLacBo
  WHERE @MaCLB IS NULL OR MaCLB = @MaCLB
END
GO
CREATE PROCEDURE DuongLinkCauLacBo_Them(@MaCLB char(10), @NenTang nvarchar(50), @DuongLienKet nvarchar(MAX)) AS BEGIN
  INSERT INTO DuongLinkCauLacBo(MaCLB, NenTang, DuongLienKet)
  VALUES (@MaCLB, @NenTang, @DuongLienKet)
END
GO
CREATE PROCEDURE DuongLinkCauLacBo_Xoa(@MaCLB char(10), @MaLienKet int) AS BEGIN
  DELETE FROM DuongLinkCauLacBo
  WHERE MaCLB = @MaCLB AND MaLienKet = @MaLienKet
END
GO
CREATE PROCEDURE DuongLinkCauLacBo_Sua(@MaCLB char(10), @MaLienKet int, @NenTang nvarchar(50) = NULL, @DuongLienKet nvarchar(MAX) = NULL) AS BEGIN
  UPDATE DuongLinkCauLacBo
  SET NenTang = ISNULL(@NenTang, NenTang),
	  DuongLienKet = ISNULL(@DuongLienKet, DuongLienKet)
  WHERE MaCLB = @MaCLB AND MaLienKet = @MaLienKet
END
GO
INSERT INTO DuongLinkCauLacBo (MaCLB, NenTang, DuongLienKet) VALUES
  ('8sDaA84CLB', 'Website', 'https://ktkthcm.edu.vn/'),
  ('8sDaA84CLB', 'Facebook', 'https://www.facebook.com/tuyensinh.hotec'),
  ('fa5eW5sCLB', 'Facebook', 'https://www.facebook.com/TruongCaoDangKinhTeKyThuatTPHCM/'),
  ('6sa6cW4CLB', 'Website', 'https://ktkthcm.edu.vn/'),
  ('6sa6cW4CLB', 'Website', 'https://www.google.com/'),
  ('6sa6cW4CLB', 'Youtube', 'https://www.youtube.com/@TruongCaoangKinhteKythuatTPHCM'),
  ('6sa6cW4CLB', 'Youtube', 'https://www.youtube.com/@truongkinhtekythuatthanhphohcm'),
  ('6sa6cW4CLB', 'TikTok', 'https://www.tiktok.com')
GO

-- #endregion

-- #region LoaiLich

CREATE TABLE LoaiLich(
  MaLoaiLich char(10) NOT NULL,
  TenLoaiLich nvarchar(50) NOT NULL,
  MaMau int NOT NULL, /* Mã hex, không có alpha */
  CONSTRAINT PK_LoaiLich PRIMARY KEY (MaLoaiLich),
)
GO
CREATE PROCEDURE LoaiLich_DanhSach AS BEGIN
  SELECT MaLoaiLich, TenLoaiLich, MaMau
  FROM LoaiLich
END
GO
CREATE PROCEDURE LoaiLich_Them(@MaLoaiLich char(10), @TenLoaiLich nvarchar(50), @MaMau int) AS BEGIN
  INSERT INTO LoaiLich (MaLoaiLich, TenLoaiLich, MaMau)
  VALUES (@MaLoaiLich, @TenLoaiLich, @MaMau)
END
GO
CREATE PROCEDURE LoaiLich_Sua(@MaLoaiLich char(10), @TenLoaiLich nvarchar(50) = NULL, @MaMau int = NULL) AS BEGIN
  UPDATE LoaiLich
  SET TenLoaiLich = ISNULL(@TenLoaiLich, TenLoaiLich),
      MaMau = ISNULL(@MaMau, MaMau)
  WHERE MaLoaiLich = @MaLoaiLich
END
GO
CREATE PROCEDURE LoaiLich_Xoa(@MaLoaiLich char(10)) AS BEGIN
  DELETE FROM LoaiLich
  WHERE MaLoaiLich = @MaLoaiLich
END
GO
INSERT INTO LoaiLich (MaLoaiLich, TenLoaiLich, MaMau) VALUES
  ('VqGaCV1rKL', N'Lịch thi đấu', 0x1a6bdd),
  ('OznZNfPxKL', N'Lịch tập luyện', 0x1abe8b),
  ('qVjudHGjKL', N'Lịch họp', 0x1fa615)
GO

-- #endregion

-- #region Lich

CREATE TABLE Lich(
  MaLich char(10) NOT NULL,
  MaLoaiLich char(10) NOT NULL,
  ChuDe nvarchar(255) NOT NULL,
  DiaDiem nvarchar(255) NOT NULL,
  LapLai tinyint NOT NULL DEFAULT 0, /* 0: Không lặp, 1-6: Lặp N ngày, 7: Lặp mỗi tuần, 8: Mỗi tháng */
  NgayBatDau date NOT NULL,
  NgayKetThuc date,
  ThoiGianBatDau time(0) NOT NULL,
  ThoiGianKetThuc time(0) NOT NULL,
  NoiDung nvarchar(max) NOT NULL,
  MaCLB char(10) NOT NULL,
  CONSTRAINT PK_Lich PRIMARY KEY CLUSTERED (MaLich),
  CONSTRAINT FK_Lich_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB),
  CONSTRAINT FK_Lich_LoaiLich FOREIGN KEY (MaLoaiLich) REFERENCES LoaiLich (MaLoaiLich)
)
GO
CREATE PROCEDURE Lich_Them (
  @MaLich char(10),
  @MaLoaiLich char(10),
  @ChuDe nvarchar(255),
  @DiaDiem nvarchar(255),
  @LapLai tinyint,
  @NgayBatDau date,
  @NgayKetThuc date,
  @ThoiGianBatDau time(0),
  @ThoiGianKetThuc time(0),
  @NoiDung nvarchar(max),
  @MaCLB char(10)
) AS BEGIN
  INSERT INTO Lich (MaLich, MaLoaiLich, ChuDe, DiaDiem, LapLai, NgayBatDau, NgayKetThuc, ThoiGianBatDau, ThoiGianKetThuc, NoiDung, MaCLB)
  VALUES (@MaLich, @MaLoaiLich, @ChuDe, @DiaDiem, @LapLai, @NgayBatDau, @NgayKetThuc, @ThoiGianBatDau, @ThoiGianKetThuc, @NoiDung, @MaCLB)
END
GO
CREATE PROCEDURE Lich_Sua (
  @MaLich char(10),
  @MaLoaiLich char(10) = NULL,
  @ChuDe nvarchar(255) = NULL,
  @DiaDiem nvarchar(255) = NULL,
  @LapLai tinyint = NULL,
  @NgayBatDau date = NULL,
  @NgayKetThuc date = NULL,
  @ThoiGianBatDau time(0) = NULL,
  @ThoiGianKetThuc time(0) = NULL,
  @NoiDung nvarchar(MAX) = NULL,
  @MaCLB char(10) = NULL
) AS BEGIN
  UPDATE Lich SET
    MaLoaiLich = ISNULL(@MaLoaiLich, MaLoaiLich),
    ChuDe = ISNULL(@ChuDe, ChuDe),
    DiaDiem = ISNULL(@DiaDiem, DiaDiem),
    LapLai = ISNULL(@LapLai, LapLai),
    NgayBatDau = ISNULL(@NgayBatDau, NgayBatDau),
    NgayKetThuc = ISNULL(@NgayKetThuc, NgayKetThuc),
    ThoiGianBatDau = ISNULL(@ThoiGianBatDau, ThoiGianBatDau),
    ThoiGianKetThuc = ISNULL(@ThoiGianKetThuc, ThoiGianKetThuc),
    NoiDung = ISNULL(@NoiDung, NoiDung),
    MaCLB = ISNULL(@MaCLB, MaCLB)
  WHERE MaLich = @MaLich
END
GO
CREATE PROCEDURE Lich_Xoa (@MaLich char(10)) AS BEGIN
  DELETE FROM Lich
  WHERE MaLich = @MaLich
END
GO
CREATE PROCEDURE Lich_ThongTin (@MaLich char(10)) AS BEGIN
  SELECT *
  FROM Lich
  WHERE MaLich = @MaLich
END
GO
CREATE PROCEDURE Lich_DanhSach (@MaCLB char(10)) AS BEGIN
  SELECT Lich.*, MaMau
  FROM Lich JOIN LoaiLich ON Lich.MaLoaiLich = LoaiLich.MaLoaiLich
  WHERE MaCLB = @MaCLB
END
GO

-- #endregion

-- #region DiemDanh
/*
CREATE TABLE DiemDanh(
  MaDiemDanh char(10) NOT NULL,
  TacGia char(10) NOT NULL,
  MaCLB char(10) NOT NULL,
  ThoiGian datetime NOT NULL,
  HienDien int NOT NULL,
  CONSTRAINT PK_DiemDanh PRIMARY KEY CLUSTERED (MaDiemDanh),
  CONSTRAINT FK_DiemDanh_CauLacBo FOREIGN KEY(MaCLB) REFERENCES CauLacBo (MaCLB),
  CONSTRAINT FK_DiemDanh_NguoiDung FOREIGN KEY(TacGia) REFERENCES NguoiDung (MaNguoiDung)
)
GO
CREATE PROCEDURE DiemDanh_Them (
  @MaDiemDanh char(10),
  @TacGia char(10),
  @MaCLB nvarchar(255),
  @ThoiGian datetime,
  @HienDien int
) AS BEGIN
  INSERT INTO DiemDanh (MaDiemDanh, TacGia, MaCLB, ThoiGian, HienDien)
  VALUES (@MaDiemDanh, @TacGia, @MaCLB, @ThoiGian, @HienDien)
END
GO
*/
-- #endregion

-- #region BaiViet

CREATE TABLE BaiViet(
	MaBaiViet char(10) NOT NULL,
	MaTacGia char(10) NOT NULL,
	MaCLB char(10) NOT NULL,
	ThoiGianTao datetime NOT NULL,
	CacNhan nvarchar(255) NOT NULL,
	TieuDe nvarchar(255) NOT NULL,
	NoiDung nvarchar(max) NOT NULL, /* markdown */
	CONSTRAINT PK_BaiViet PRIMARY KEY CLUSTERED (MaBaiViet),
	CONSTRAINT FK_BaiViet_NguoiDung FOREIGN KEY (MaTacGia) REFERENCES NguoiDung (MaNguoiDung),
	CONSTRAINT FK_BaiViet_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB)
)
GO
CREATE PROCEDURE BaiViet_Them(
    @MaBaiViet char(10),
    @MaTacGia char(10),
    @MaCLB char(10),
    @ThoiGianTao datetime,
    @CacNhan nvarchar(255),
    @TieuDe nvarchar(255),
    @NoiDung nvarchar(max)
) AS BEGIN
    INSERT INTO BaiViet (MaBaiViet, MaTacGia, MaCLB, ThoiGianTao, CacNhan, TieuDe, NoiDung)
	VALUES (@MaBaiViet, @MaTacGia, @MaCLB, @ThoiGianTao, @CacNhan, @TieuDe, @NoiDung)
END
GO
CREATE PROCEDURE BaiViet_Sua(
    @MaBaiViet char(10),
    @MaTacGia char(10) = NULL,
    @MaCLB char(10) = NULL,
    @ThoiGianTao datetime = NULL,
    @CacNhan nvarchar(255) = NULL,
    @TieuDe nvarchar(255) = NULL,
    @NoiDung nvarchar(MAX) = NULL
) AS BEGIN
    UPDATE BaiViet SET
		MaTacGia = ISNULL(@MaTacGia, MaTacGia),
		MaCLB = ISNULL(@MaCLB, MaCLB),
		ThoiGianTao = ISNULL(@ThoiGianTao, ThoiGianTao),
		CacNhan = ISNULL(@CacNhan, CacNhan),
		TieuDe = ISNULL(@TieuDe, TieuDe),
		NoiDung = ISNULL(@NoiDung, NoiDung)
	WHERE MaBaiViet = @MaBaiViet
END
GO
CREATE PROCEDURE BaiViet_DanhSach(@MaCLB char(10)) AS BEGIN
    SELECT MaBaiViet, MaTacGia, Ho, Lot, Ten, TieuDe, CacNhan, BaiViet.ThoiGianTao
	FROM BaiViet JOIN NguoiDung ON BaiViet.MaTacGia = NguoiDung.MaNguoiDung
	WHERE MaCLB = @MaCLB
	ORDER BY BaiViet.ThoiGianTao DESC
END
GO
CREATE PROCEDURE BaiViet_ThongTin(@MaBaiViet char(10)) AS BEGIN
    SELECT MaBaiViet, MaTacGia, Ho, Lot, Ten, TieuDe, CacNhan, MaCLB, BaiViet.ThoiGianTao, NoiDung
	FROM BaiViet JOIN NguoiDung ON BaiViet.MaTacGia = NguoiDung.MaNguoiDung
	WHERE MaBaiViet = @MaBaiViet
END
GO

-- #endregion

-- #region ThongBao

CREATE TABLE ThongBao(
  MaThongBao char(10) NOT NULL,
  TacGia char(10) NOT NULL,
  ThoiGianTao datetime NOT NULL,
  TieuDe nvarchar(255) NOT NULL,
  NoiDung nvarchar(max) NOT NULL,
  MaCLB char(10) NOT NULL,
  CONSTRAINT PK_ThongBao PRIMARY KEY CLUSTERED (MaThongBao),
  CONSTRAINT FK_ThongBao_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB),
  CONSTRAINT FK_ThongBao_NguoiDung FOREIGN KEY (TacGia) REFERENCES NguoiDung (MaNguoiDung)
)
GO
CREATE PROCEDURE ThongBao_Them (@MaThongBao char(10), @TacGia char(10), @ThoiGianTao datetime, @TieuDe nvarchar(255), @NoiDung nvarchar(max), @MaCLB char(10)) AS BEGIN
  INSERT INTO ThongBao (MaThongBao, TacGia, ThoiGianTao, TieuDe, NoiDung, MaCLB)
  VALUES (@MaThongBao, @TacGia, @ThoiGianTao, @TieuDe, @NoiDung, @MaCLB)
END
GO
CREATE PROCEDURE ThongBao_DanhSach (@MaNguoiDung char(10)) AS BEGIN
  SELECT DISTINCT MaThongBao, TacGia, ThongBao.ThoiGianTao, TieuDe, ThongBao.MaCLB, Ho, Lot, Ten, TenCLB
  FROM ThongBao JOIN CauLacBo ON ThongBao.MaCLB = CauLacBo.MaCLB
                JOIN ThanhVien ON CauLacBo.MaCLB = ThanhVien.MaCLB
				JOIN NguoiDung ON TacGia = NguoiDung.MaNguoiDung
  WHERE ThongBao.ThoiGianTao >= NguoiDung.ThoiGianTao
  ORDER BY ThoiGianTao DESC
END
GO
CREATE PROCEDURE ThongBao_SqlDependency (@CacMaCauLacBo varchar(MAX), @MaNguoiDung char(10)) AS BEGIN
  SELECT MaThongBao
  FROM dbo.ThongBao
  WHERE TacGia <> @MaNguoiDung AND @CacMaCauLacBo LIKE CONCAT('%', MaCLB, '%')
END
GO
CREATE PROCEDURE ThongBao_ThongTin (@MaThongBao char(10)) AS BEGIN
  SELECT ThongBao.*, Ho, Lot, Ten, TenCLB
  FROM ThongBao JOIN NguoiDung ON ThongBao.TacGia = NguoiDung.MaNguoiDung
                JOIN CauLacBo ON ThongBao.MaCLB = CauLacBo.MaCLB
  WHERE MaThongBao = @MaThongBao
END

-- #endregion

-- #region ThanhVien

CREATE TABLE ThanhVien (
  MaNguoiDung char(10) NOT NULL,
  MaCLB char(10) NOT NULL,
  ChucVu tinyint NOT NULL, /* 0: Thành viên thường, 1: Phó nhóm, 2: Trưởng nhóm */
  CONSTRAINT PK_ThanhVien PRIMARY KEY CLUSTERED (MaNguoiDung, MaCLB),
  CONSTRAINT FK_ThanhVien_CauLacBo FOREIGN KEY (MaCLB) REFERENCES CauLacBo (MaCLB),
  CONSTRAINT FK_ThanhVien_NguoiDung FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung (MaNguoiDung)
)
GO
CREATE PROCEDURE ThanhVien_Them (
  @MaNguoiDung char(10),
  @MaCLB char(10),
  @ChucVu tinyint
) AS BEGIN
  INSERT INTO ThanhVien (MaNguoiDung, MaCLB, ChucVu)
  VALUES (@MaNguoiDung, @MaCLB, @ChucVu)
END
GO
CREATE PROCEDURE ThanhVien_DanhSach (@MaCLB char(10)) AS BEGIN
  SELECT NguoiDung.*, MaCLB, ChucVu
  FROM ThanhVien JOIN NguoiDung ON ThanhVien.MaNguoiDung = NguoiDung.MaNguoiDung
  WHERE MaCLB = @MaCLB
END
GO
CREATE PROCEDURE ThanhVien_ThongTin (@MaCLB char(10), @MaNguoiDung char(10)) AS BEGIN
  SELECT NguoiDung.*, MaCLB, ChucVu
  FROM ThanhVien JOIN NguoiDung ON ThanhVien.MaNguoiDung = NguoiDung.MaNguoiDung
  WHERE MaCLB = @MaCLB AND NguoiDung.MaNguoiDung = @MaNguoiDung
END
GO
CREATE PROCEDURE ThanhVien_Sua (
  @MaNguoiDung char(10),
  @MaCLB char(10),
  @ChucVu tinyint = NULL
) AS BEGIN
  UPDATE ThanhVien
  SET ChucVu = ISNULL(@ChucVu, ChucVu)
  WHERE MaNguoiDung = @MaNguoiDung AND MaCLB = @MaCLB
END
GO
CREATE PROCEDURE ThanhVien_Xoa (
  @MaNguoiDung char(10),
  @MaCLB char(10)
) AS BEGIN
  DELETE FROM ThanhVien
  WHERE MaNguoiDung = @MaNguoiDung AND MaCLB = @MaCLB
END
GO
INSERT INTO ThanhVien (MaNguoiDung, MaCLB, ChucVu) VALUES
   ('IxbBG93Z0U', 'w855sAsCLB', 0),
   ('bYVbR3IgUU', 'fa5eW5sCLB', 0),
   ('q6tsLjzUiU', '8sDaA84CLB', 0),
   ('GPkIyyqSzU', '8sDaA84CLB', 1),
   ('bYVbR3IgUU', '6sa6cW4CLB', 0),
   ('7HRgDGyZAU', '8sDaA84CLB', 0),
   ('q6tsLjzUiU', '6sa6cW4CLB', 0),
   ('Ao7AwPO7NU', '8sDaA84CLB', 2),
   ('mdmxOBEVhU', '8sDaA84CLB', 2),
   ('mdmxOBEVhU', 'fa5eW5sCLB', 0),
   ('b8EsFmarDU', '8sDaA84CLB', 0),
   ('tw8PUeQgSU', 'fa5eW5sCLB', 0),
   ('EGGfmv3WPU', '6sa6cW4CLB', 0),
   ('vcjH9vf2ZU', '6sa6cW4CLB', 0),
   ('vcjH9vf2ZU', 'w855sAsCLB', 2),
   ('K3hMg4a10U', '8sDaA84CLB', 0),
   ('jmAHTSj5cU', '6sa6cW4CLB', 0),
   ('Zn5y0UhMoU', 'fa5eW5sCLB', 2),
   ('K3hMg4a10U', '6sa6cW4CLB', 0),
   ('2ztE5oVI0U', '6sa6cW4CLB', 0),
   ('EW6L7L1IHU', '6sa6cW4CLB', 2),
   ('Tb7sFvW2sU', 'w855sAsCLB', 1),
   ('p6vHgIjbeU', '6sa6cW4CLB', 0),
   ('RGJ8YZdM8U', 'fa5eW5sCLB', 0),
   ('BPtDufvxiU', 'fa5eW5sCLB', 0),
   ('BPtDufvxiU', '6sa6cW4CLB', 1),
   ('CDLoby6vYU', '8sDaA84CLB', 0),
   ('QoAT4ZaIYU', 'fa5eW5sCLB', 0),
   ('nDhR3X8MhU', 'w855sAsCLB', 0),
   ('3A0NGVbgvU', 'w855sAsCLB', 0),
   ('j8RxtB6WbU', '8sDaA84CLB', 0),
   ('3hl381IaYU', '8sDaA84CLB', 0),
   ('xEub1JcMpU', '8sDaA84CLB', 0),
   ('O21btKjcBU', '8sDaA84CLB', 0),
   ('HeMGZxVnaU', '8sDaA84CLB', 0),
   ('Tb7sFvW2sU', 'fa5eW5sCLB', 0),
   ('O21btKjcBU', 'fa5eW5sCLB', 1),
   ('HeMGZxVnaU', 'fa5eW5sCLB', 0),
   ('tw8PUeQgSU', '8sDaA84CLB', 0),
   ('nDhR3X8MhU', '8sDaA84CLB', 0),
   ('xEub1JcMpU', 'w855sAsCLB', 0),
   ('p6vHgIjbeU', 'w855sAsCLB', 0),
   ('2ztE5oVI0U', 'fa5eW5sCLB', 0),
   ('3hl381IaYU', 'fa5eW5sCLB', 0),
   ('QoAT4ZaIYU', '6sa6cW4CLB', 0),
   ('CDLoby6vYU', 'fa5eW5sCLB', 0),
   ('2ztE5oVI0U', 'w855sAsCLB', 0),
   ('RGJ8YZdM8U', 'w855sAsCLB', 0),
   ('BPtDufvxiU', '8sDaA84CLB', 0),
   ('RGJ8YZdM8U', '8sDaA84CLB', 0),
   ('p6vHgIjbeU', '8sDaA84CLB', 0),
   ('tw8PUeQgSU', '6sa6cW4CLB', 0)
GO

-- #endregion