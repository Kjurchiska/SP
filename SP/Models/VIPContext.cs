using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SP.Models
{
    public partial class VIPContext : DbContext
    {
        public VIPContext()
        {
        }

        public VIPContext(DbContextOptions<VIPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Broj> Broj { get; set; }
        public virtual DbSet<Delatnost> Delatnost { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Kredit> Kredit { get; set; }
        public virtual DbSet<Mesto> Mesto { get; set; }
        public virtual DbSet<Operater> Operater { get; set; }
        public virtual DbSet<Oprema> Oprema { get; set; }
        public virtual DbSet<OrganizacionaJedinica> OrganizacionaJedinica { get; set; }
        public virtual DbSet<Ponuda> Ponuda { get; set; }
        public virtual DbSet<PonudaUredjajaItarifnihPaketa> PonudaUredjajaItarifnihPaketa { get; set; }
        public virtual DbSet<PotencijalniKlijent> PotencijalniKlijent { get; set; }
        public virtual DbSet<PotvrdaOrealizacijiPodrske> PotvrdaOrealizacijiPodrske { get; set; }
        public virtual DbSet<Pozicii> Pozicii { get; set; }
        public virtual DbSet<Pozicija> Pozicija { get; set; }
        public virtual DbSet<Proizvodjac> Proizvodjac { get; set; }
        public virtual DbSet<Proracun> Proracun { get; set; }
        public virtual DbSet<Prostor> Prostor { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<StavkaPonude> StavkaPonude { get; set; }
        public virtual DbSet<StavkaPonudeUredjaj> StavkaPonudeUredjaj { get; set; }
        public virtual DbSet<StavkaProracuna> StavkaProracuna { get; set; }
        public virtual DbSet<StavkaThponude> StavkaThponude { get; set; }
        public virtual DbSet<StavkaZahteva> StavkaZahteva { get; set; }
        public virtual DbSet<StavkaZahtevaAs> StavkaZahtevaAs { get; set; }
        public virtual DbSet<StavkaZahtevaTp> StavkaZahtevaTp { get; set; }
        public virtual DbSet<TarifniPaket> TarifniPaket { get; set; }
        public virtual DbSet<TekuciRacun> TekuciRacun { get; set; }
        public virtual DbSet<Thponuda> Thponuda { get; set; }
        public virtual DbSet<Thugovor> Thugovor { get; set; }
        public virtual DbSet<Thusluga> Thusluga { get; set; }
        public virtual DbSet<Ugovor> Ugovor { get; set; }
        public virtual DbSet<Ulica> Ulica { get; set; }
        public virtual DbSet<Uredjaj> Uredjaj { get; set; }
        public virtual DbSet<Valuta> Valuta { get; set; }
        public virtual DbSet<VrstaKredita> VrstaKredita { get; set; }
        public virtual DbSet<VrstaPaketa> VrstaPaketa { get; set; }
        public virtual DbSet<VrstaUsluge> VrstaUsluge { get; set; }
        public virtual DbSet<ZahtevZaAktivacijuServisa> ZahtevZaAktivacijuServisa { get; set; }
        public virtual DbSet<ZahtevZaPodacima> ZahtevZaPodacima { get; set; }
        public virtual DbSet<ZahtevZaPomocPriInstalacijiThusluge> ZahtevZaPomocPriInstalacijiThusluge { get; set; }
        public virtual DbSet<ZahtevZaProveruKreditneSposobnosti> ZahtevZaProveruKreditneSposobnosti { get; set; }
        public virtual DbSet<ZahtevZaProveruTehnickihUsluga> ZahtevZaProveruTehnickihUsluga { get; set; }
        public virtual DbSet<ZahtevZaTehnickomPodrskom> ZahtevZaTehnickomPodrskom { get; set; }
        public virtual DbSet<ZahtevZaThuslugom> ZahtevZaThuslugom { get; set; }
        public virtual DbSet<Zaposleni> Zaposleni { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-K913VI8;Database=VIP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broj>(entity =>
            {
                entity.HasKey(e => new { e.BrojAdrese, e.Idulice, e.PostanskiBroj })
                    .HasName("PK__Broj__503EA8B42ABBDAF1");

                entity.Property(e => e.BrojAdrese).ValueGeneratedOnAdd();

                entity.Property(e => e.Idulice).HasColumnName("IDUlice");

                entity.HasOne(d => d.Ulica)
                    .WithMany(p => p.Broj)
                    .HasForeignKey(d => new { d.Idulice, d.PostanskiBroj })
                    .HasConstraintName("FK__Broj__36B12243");
            });

            modelBuilder.Entity<Delatnost>(entity =>
            {
                entity.HasKey(e => e.SifraDel)
                    .HasName("PK__Delatnos__DE3B70F14C607869");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.HasKey(e => e.Idklijenta)
                    .HasName("PK__Klijent__3A22A56259457EBD");

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.GodinaOsnivanja).HasColumnType("date");

                entity.Property(e => e.IdpotKlijenta).HasColumnName("IDPotKlijenta");

                entity.Property(e => e.Idulice).HasColumnName("IDUlice");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pib)
                    .IsRequired()
                    .HasColumnName("PIB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebStrana)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdpotKlijentaNavigation)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => d.IdpotKlijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Klijent__IDPotKl__3F466844");

                entity.HasOne(d => d.SifraDelNavigation)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => d.SifraDel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Klijent__SifraDe__3D5E1FD2");

                entity.HasOne(d => d.Broj)
                    .WithMany(p => p.Klijent)
                    .HasForeignKey(d => new { d.BrojAdrese, d.Idulice, d.PostanskiBroj })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Klijent__3E52440B");
            });

            modelBuilder.Entity<Kredit>(entity =>
            {
                entity.HasKey(e => new { e.Idkr, e.SifraVrsteKr, e.Idklijenta })
                    .HasName("PK__Kredit__D8A7E7229F38B651");

                entity.Property(e => e.Idkr)
                    .HasColumnName("IDKr")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.DatumKrajaOtplate).HasColumnType("date");

                entity.Property(e => e.DatumPocetkaKoriscenja).HasColumnType("date");

                entity.Property(e => e.DatumPocetkaOtplate).HasColumnType("date");

                entity.Property(e => e.IskorisceniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OdobreniIznos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OstatakDuga).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PeriodOtplate).HasColumnType("date");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdklijentaNavigation)
                    .WithMany(p => p.Kredit)
                    .HasForeignKey(d => d.Idklijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Kredit__IDKlijen__4AB81AF0");

                entity.HasOne(d => d.SifraVrsteKrNavigation)
                    .WithMany(p => p.Kredit)
                    .HasForeignKey(d => d.SifraVrsteKr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Kredit__SifraVrs__4BAC3F29");
            });

            modelBuilder.Entity<Mesto>(entity =>
            {
                entity.HasKey(e => e.PostanskiBroj)
                    .HasName("PK__Mesto__9FDD638DE9D1C696");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Operater>(entity =>
            {
                entity.HasKey(e => e.Idoperatera)
                    .HasName("PK__Operater__BD92399FACF1E17D");

                entity.Property(e => e.Idoperatera).HasColumnName("IDOperatera");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Oprema>(entity =>
            {
                entity.HasKey(e => new { e.Idopreme, e.Idvrste, e.Idprostora })
                    .HasName("PK__Oprema__497DCC462012B36B");

                entity.Property(e => e.Idopreme)
                    .HasColumnName("IDOpreme")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idvrste).HasColumnName("IDVrste");

                entity.Property(e => e.Idprostora).HasColumnName("IDProstora");

                entity.Property(e => e.Garancija)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdprostoraNavigation)
                    .WithMany(p => p.Oprema)
                    .HasForeignKey(d => d.Idprostora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Oprema__IDProsto__25518C17");

                entity.HasOne(d => d.IdvrsteNavigation)
                    .WithMany(p => p.Oprema)
                    .HasForeignKey(d => d.Idvrste)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Oprema__IDVrste__245D67DE");
            });

            modelBuilder.Entity<OrganizacionaJedinica>(entity =>
            {
                entity.HasKey(e => e.IdorgJed)
                    .HasName("PK__Organiza__3B108EF7DB34F036");

                entity.Property(e => e.IdorgJed).HasColumnName("IDOrgJed");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ponuda>(entity =>
            {
                entity.HasKey(e => e.Idponude)
                    .HasName("PK__Ponuda__9983382FAD2E754C");

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idproracuna).HasColumnName("IDProracuna");

                entity.Property(e => e.RokPrihvatanja).HasColumnType("date");

                entity.HasOne(d => d.IdproracunaNavigation)
                    .WithMany(p => p.Ponuda)
                    .HasForeignKey(d => d.Idproracuna)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ponuda__IDProrac__787EE5A0");
            });

            modelBuilder.Entity<PonudaUredjajaItarifnihPaketa>(entity =>
            {
                entity.HasKey(e => e.Idponude)
                    .HasName("PK__PonudaUr__9983382F38A3F30A");

                entity.ToTable("PonudaUredjajaITarifnihPaketa");

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.Datum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.HasOne(d => d.IdklijentaNavigation)
                    .WithMany(p => p.PonudaUredjajaItarifnihPaketa)
                    .HasForeignKey(d => d.Idklijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PonudaUre__IDKli__571DF1D5");

                entity.HasOne(d => d.IdzapNavigation)
                    .WithMany(p => p.PonudaUredjajaItarifnihPaketa)
                    .HasForeignKey(d => d.Idzap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PonudaUre__IDZap__5812160E");
            });

            modelBuilder.Entity<PotencijalniKlijent>(entity =>
            {
                entity.HasKey(e => e.IdpotKlijenta)
                    .HasName("PK__Potencij__FFEF8D876C2CF93C");

                entity.Property(e => e.IdpotKlijenta).HasColumnName("IDPotKlijenta");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Napomena)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ZaposleniPNavigation)
                    .WithMany(p => p.PotencijalniKlijentZaposleniPNavigation)
                    .HasForeignKey(d => d.ZaposleniP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Potencija__Zapos__2F10007B");

                entity.HasOne(d => d.ZaposleniSNavigation)
                    .WithMany(p => p.PotencijalniKlijentZaposleniSNavigation)
                    .HasForeignKey(d => d.ZaposleniS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Potencija__Zapos__2E1BDC42");
            });

            modelBuilder.Entity<PotvrdaOrealizacijiPodrske>(entity =>
            {
                entity.HasKey(e => e.Idpotvrde)
                    .HasName("PK__PotvrdaO__B56CDF4A7DDD8BEF");

                entity.ToTable("PotvrdaORealizacijiPodrske");

                entity.Property(e => e.Idpotvrde).HasColumnName("IDPotvrde");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.IdzahtevaTp).HasColumnName("IDZahtevaTP");

                entity.HasOne(d => d.StavkaZahtevaTp)
                    .WithMany(p => p.PotvrdaOrealizacijiPodrske)
                    .HasForeignKey(d => new { d.Rbr, d.IdzahtevaTp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PotvrdaORealizac__14270015");
            });

            modelBuilder.Entity<Pozicii>(entity =>
            {
                entity.HasKey(e => e.Idpoz)
                    .HasName("PK__Pozicii__98F9D012D90484FF");

                entity.Property(e => e.Idpoz).HasColumnName("IDPoz");

                entity.Property(e => e.IdpozK).HasColumnName("IDPozK");

                entity.HasOne(d => d.IdpozKNavigation)
                    .WithMany(p => p.Pozicii)
                    .HasForeignKey(d => d.IdpozK)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pozicii__IDPozK__286302EC");
            });

            modelBuilder.Entity<Pozicija>(entity =>
            {
                entity.HasKey(e => e.Idpoz)
                    .HasName("PK__Pozicija__98F9D01222C57E00");

                entity.Property(e => e.Idpoz).HasColumnName("IDPoz");

                entity.Property(e => e.IdorgJed).HasColumnName("IDOrgJed");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdorgJedNavigation)
                    .WithMany(p => p.Pozicija)
                    .HasForeignKey(d => d.IdorgJed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pozicija__IDOrgJ__25869641");
            });

            modelBuilder.Entity<Proizvodjac>(entity =>
            {
                entity.HasKey(e => e.Idproizvodjaca)
                    .HasName("PK__Proizvod__4ABF484F0E484A67");

                entity.Property(e => e.Idproizvodjaca).HasColumnName("IDProizvodjaca");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Proracun>(entity =>
            {
                entity.HasKey(e => e.Idproracuna)
                    .HasName("PK__Proracun__C27C214C91C43F39");

                entity.Property(e => e.Idproracuna).HasColumnName("IDProracuna");

                entity.Property(e => e.CenaSaPopustom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.IdzapP).HasColumnName("IDZapP");

                entity.Property(e => e.IdzapS).HasColumnName("IDZapS");

                entity.Property(e => e.Napomena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdzapPNavigation)
                    .WithMany(p => p.ProracunIdzapPNavigation)
                    .HasForeignKey(d => d.IdzapP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proracun__IDZapP__70DDC3D8");

                entity.HasOne(d => d.IdzapSNavigation)
                    .WithMany(p => p.ProracunIdzapSNavigation)
                    .HasForeignKey(d => d.IdzapS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Proracun__IDZapS__6FE99F9F");
            });

            modelBuilder.Entity<Prostor>(entity =>
            {
                entity.HasKey(e => e.Idprostora)
                    .HasName("PK__Prostor__1D3C3C420CFEB0B7");

                entity.Property(e => e.Idprostora).HasColumnName("IDProstora");

                entity.Property(e => e.Idulice).HasColumnName("IDUlice");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Broj)
                    .WithMany(p => p.Prostor)
                    .HasForeignKey(d => new { d.BrojAdrese, d.Idulice, d.PostanskiBroj })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prostor__1F98B2C1");
            });

            modelBuilder.Entity<Servis>(entity =>
            {
                entity.HasKey(e => e.Idservisa)
                    .HasName("PK__Servis__504E7D52497D6D94");

                entity.Property(e => e.Idservisa).HasColumnName("IDServisa");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StavkaPonude>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.Idponude })
                    .HasName("PK__StavkaPo__2368A8B11AB29663");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.Idproracuna).HasColumnName("IDProracuna");

                entity.HasOne(d => d.IdponudeNavigation)
                    .WithMany(p => p.StavkaPonude)
                    .HasForeignKey(d => d.Idponude)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StavkaPon__IDPon__7B5B524B");

                entity.HasOne(d => d.StavkaProracuna)
                    .WithMany(p => p.StavkaPonude)
                    .HasForeignKey(d => new { d.RbrProracun, d.Idproracuna })
                    .HasConstraintName("FK__StavkaPonude__7C4F7684");
            });

            modelBuilder.Entity<StavkaPonudeUredjaj>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.Idponude })
                    .HasName("PK__StavkaPo__2368A8B14C2C7B97");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.Idtf).HasColumnName("IDTF");

                entity.Property(e => e.Iduredjaja).HasColumnName("IDUredjaja");

                entity.HasOne(d => d.IdponudeNavigation)
                    .WithMany(p => p.StavkaPonudeUredjaj)
                    .HasForeignKey(d => d.Idponude)
                    .HasConstraintName("FK__StavkaPon__IDPon__66603565");

                entity.HasOne(d => d.IdtfNavigation)
                    .WithMany(p => p.StavkaPonudeUredjaj)
                    .HasForeignKey(d => d.Idtf)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StavkaPonu__IDTF__656C112C");

                entity.HasOne(d => d.IduredjajaNavigation)
                    .WithMany(p => p.StavkaPonudeUredjaj)
                    .HasForeignKey(d => d.Iduredjaja)
                    .HasConstraintName("FK__StavkaPon__IDUre__6477ECF3");
            });

            modelBuilder.Entity<StavkaProracuna>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.Idproracuna })
                    .HasName("PK__StavkaPr__16D75927C5C7F313");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.Idproracuna).HasColumnName("IDProracuna");

                entity.Property(e => e.Idtf).HasColumnName("IDTF");

                entity.Property(e => e.Iduredjaja).HasColumnName("IDUredjaja");

                entity.HasOne(d => d.IdproracunaNavigation)
                    .WithMany(p => p.StavkaProracuna)
                    .HasForeignKey(d => d.Idproracuna)
                    .HasConstraintName("FK__StavkaPro__IDPro__75A278F5");

                entity.HasOne(d => d.IdtfNavigation)
                    .WithMany(p => p.StavkaProracuna)
                    .HasForeignKey(d => d.Idtf)
                    .HasConstraintName("FK__StavkaPror__IDTF__74AE54BC");

                entity.HasOne(d => d.IduredjajaNavigation)
                    .WithMany(p => p.StavkaProracuna)
                    .HasForeignKey(d => d.Iduredjaja)
                    .HasConstraintName("FK__StavkaPro__IDUre__73BA3083");
            });

            modelBuilder.Entity<StavkaThponude>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.Idponude })
                    .HasName("PK__StavkaTH__2368A8B19B571F1E");

                entity.ToTable("StavkaTHPonude");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.DatumAktivacije).HasColumnType("date");

                entity.Property(e => e.Idusluge).HasColumnName("IDUsluge");

                entity.HasOne(d => d.IdponudeNavigation)
                    .WithMany(p => p.StavkaThponude)
                    .HasForeignKey(d => d.Idponude)
                    .HasConstraintName("FK__StavkaTHP__IDPon__2BFE89A6");

                entity.HasOne(d => d.IduslugeNavigation)
                    .WithMany(p => p.StavkaThponude)
                    .HasForeignKey(d => d.Idusluge)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StavkaTHP__IDUsl__2B0A656D");
            });

            modelBuilder.Entity<StavkaZahteva>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.Idzahteva })
                    .HasName("PK__StavkaZa__D25620AE4A9A44E2");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdzahtevaNavigation)
                    .WithMany(p => p.StavkaZahteva)
                    .HasForeignKey(d => d.Idzahteva)
                    .HasConstraintName("FK__StavkaZah__IDZah__6D0D32F4");
            });

            modelBuilder.Entity<StavkaZahtevaAs>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.IdzahtevaAs })
                    .HasName("PK__StavkaZa__CB30EB92603C04A1");

                entity.ToTable("StavkaZahtevaAS");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.IdzahtevaAs).HasColumnName("IDZahtevaAS");

                entity.Property(e => e.Idservisa).HasColumnName("IDServisa");

                entity.Property(e => e.RokIsporuke).HasColumnType("date");

                entity.HasOne(d => d.IdservisaNavigation)
                    .WithMany(p => p.StavkaZahtevaAs)
                    .HasForeignKey(d => d.Idservisa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StavkaZah__IDSer__09A971A2");

                entity.HasOne(d => d.IdzahtevaAsNavigation)
                    .WithMany(p => p.StavkaZahtevaAs)
                    .HasForeignKey(d => d.IdzahtevaAs)
                    .HasConstraintName("FK__StavkaZah__IDZah__0A9D95DB");
            });

            modelBuilder.Entity<StavkaZahtevaTp>(entity =>
            {
                entity.HasKey(e => new { e.Rbr, e.IdzahtevaTp })
                    .HasName("PK__StavkaZa__BB30F0BBC013E4DC");

                entity.ToTable("StavkaZahtevaTP");

                entity.Property(e => e.Rbr).ValueGeneratedOnAdd();

                entity.Property(e => e.IdzahtevaTp).HasColumnName("IDZahtevaTP");

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdzahtevaTpNavigation)
                    .WithMany(p => p.StavkaZahtevaTp)
                    .HasForeignKey(d => d.IdzahtevaTp)
                    .HasConstraintName("FK__StavkaZah__IDZah__114A936A");
            });

            modelBuilder.Entity<TarifniPaket>(entity =>
            {
                entity.HasKey(e => e.Idtf)
                    .HasName("PK__TarifniP__B87C3A8E316E2DD9");

                entity.Property(e => e.Idtf).HasColumnName("IDTF");

                entity.Property(e => e.BrojMb)
                    .IsRequired()
                    .HasColumnName("BrojMB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrojMinuta).HasColumnType("date");

                entity.Property(e => e.Idvrste).HasColumnName("IDVrste");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdvrsteNavigation)
                    .WithMany(p => p.TarifniPaket)
                    .HasForeignKey(d => d.Idvrste)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TarifniPa__IDVrs__619B8048");
            });

            modelBuilder.Entity<TekuciRacun>(entity =>
            {
                entity.HasKey(e => e.Idtr)
                    .HasName("PK__TekuciRa__B87C3AFA28DF6C88");

                entity.Property(e => e.Idtr).HasColumnName("IDTR");

                entity.Property(e => e.DatumOtvaranja).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NazivNosiocaRacuna)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProsecanMesecniOdliv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProsecanMesecniPriliv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SifraValuteNavigation)
                    .WithMany(p => p.TekuciRacun)
                    .HasForeignKey(d => d.SifraValute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TekuciRac__Sifra__4E88ABD4");
            });

            modelBuilder.Entity<Thponuda>(entity =>
            {
                entity.HasKey(e => e.Idponude)
                    .HasName("PK__THPonuda__9983382F9B16AC43");

                entity.ToTable("THPonuda");

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.Property(e => e.RokZaPotvrdu).HasColumnType("date");

                entity.HasOne(d => d.IdzahtevaNavigation)
                    .WithMany(p => p.Thponuda)
                    .HasForeignKey(d => d.Idzahteva)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__THPonuda__IDZaht__1BC821DD");

                entity.HasOne(d => d.IdzapNavigation)
                    .WithMany(p => p.Thponuda)
                    .HasForeignKey(d => d.Idzap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__THPonuda__IDZap__1CBC4616");
            });

            modelBuilder.Entity<Thugovor>(entity =>
            {
                entity.HasKey(e => e.Idugovora)
                    .HasName("PK__THUgovor__DA03585F2F301B6A");

                entity.ToTable("THUgovor");

                entity.Property(e => e.Idugovora).HasColumnName("IDUgovora");

                entity.Property(e => e.DatumDo).HasColumnType("date");

                entity.Property(e => e.DatumKreiranja).HasColumnType("date");

                entity.Property(e => e.DatumOd).HasColumnType("date");

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.HasOne(d => d.IdponudeNavigation)
                    .WithMany(p => p.Thugovor)
                    .HasForeignKey(d => d.Idponude)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__THUgovor__IDPonu__2EDAF651");
            });

            modelBuilder.Entity<Thusluga>(entity =>
            {
                entity.HasKey(e => e.Idusluge)
                    .HasName("PK__THUsluga__D7AF911A4C57541A");

                entity.ToTable("THUsluga");

                entity.Property(e => e.Idusluge).HasColumnName("IDUsluge");

                entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Idvrste).HasColumnName("IDVrste");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdvrsteNavigation)
                    .WithMany(p => p.Thusluga)
                    .HasForeignKey(d => d.Idvrste)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__THUsluga__IDVrst__282DF8C2");
            });

            modelBuilder.Entity<Ugovor>(entity =>
            {
                entity.HasKey(e => e.Idugovora)
                    .HasName("PK__Ugovor__DA03585FF5687F17");

                entity.Property(e => e.Idugovora).HasColumnName("IDUgovora");

                entity.Property(e => e.DatumDo).HasColumnType("date");

                entity.Property(e => e.DatumKreiranja).HasColumnType("date");

                entity.Property(e => e.DatumOd).HasColumnType("date");

                entity.Property(e => e.Idponude).HasColumnName("IDPonude");

                entity.Property(e => e.IdzapP).HasColumnName("IDZapP");

                entity.Property(e => e.IdzapS).HasColumnName("IDZapS");

                entity.Property(e => e.Napomena)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdponudeNavigation)
                    .WithMany(p => p.Ugovor)
                    .HasForeignKey(d => d.Idponude)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ugovor__IDPonude__7F2BE32F");

                entity.HasOne(d => d.IdzapPNavigation)
                    .WithMany(p => p.UgovorIdzapPNavigation)
                    .HasForeignKey(d => d.IdzapP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ugovor__IDZapP__01142BA1");

                entity.HasOne(d => d.IdzapSNavigation)
                    .WithMany(p => p.UgovorIdzapSNavigation)
                    .HasForeignKey(d => d.IdzapS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ugovor__IDZapS__00200768");
            });

            modelBuilder.Entity<Ulica>(entity =>
            {
                entity.HasKey(e => new { e.Idulice, e.PostanskiBroj })
                    .HasName("PK__Ulica__6224223897641C8D");

                entity.Property(e => e.Idulice)
                    .HasColumnName("IDUlice")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PostanskiBrojNavigation)
                    .WithMany(p => p.Ulica)
                    .HasForeignKey(d => d.PostanskiBroj)
                    .HasConstraintName("FK__Ulica__Postanski__33D4B598");
            });

            modelBuilder.Entity<Uredjaj>(entity =>
            {
                entity.HasKey(e => e.Iduredjaja)
                    .HasName("PK__Uredjaj__3B6413F73CC665B0");

                entity.Property(e => e.Iduredjaja).HasColumnName("IDUredjaja");

                entity.Property(e => e.Boja)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Idproizvodjaca).HasColumnName("IDProizvodjaca");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdproizvodjacaNavigation)
                    .WithMany(p => p.Uredjaj)
                    .HasForeignKey(d => d.Idproizvodjaca)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uredjaj__IDProiz__5CD6CB2B");
            });

            modelBuilder.Entity<Valuta>(entity =>
            {
                entity.HasKey(e => e.SifraValute)
                    .HasName("PK__Valuta__C4FBB3E8FBDF06BC");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VrstaKredita>(entity =>
            {
                entity.HasKey(e => e.SifraVrsteKr)
                    .HasName("PK__VrstaKre__3E0040A14A927417");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SifraValuteNavigation)
                    .WithMany(p => p.VrstaKredita)
                    .HasForeignKey(d => d.SifraValute)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VrstaKred__Sifra__47DBAE45");
            });

            modelBuilder.Entity<VrstaPaketa>(entity =>
            {
                entity.HasKey(e => e.Idvrste)
                    .HasName("PK__VrstaPak__7A8B760979F8FAFD");

                entity.Property(e => e.Idvrste).HasColumnName("IDVrste");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VrstaUsluge>(entity =>
            {
                entity.HasKey(e => e.Idvrste)
                    .HasName("PK__VrstaUsl__7A8B7609661573E6");

                entity.Property(e => e.Idvrste).HasColumnName("IDVrste");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZahtevZaAktivacijuServisa>(entity =>
            {
                entity.HasKey(e => e.IdzahtevaAs)
                    .HasName("PK__ZahtevZa__1C070A1109650A60");

                entity.Property(e => e.IdzahtevaAs).HasColumnName("IDZahtevaAS");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idugovora).HasColumnName("IDUgovora");

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.HasOne(d => d.IdugovoraNavigation)
                    .WithMany(p => p.ZahtevZaAktivacijuServisa)
                    .HasForeignKey(d => d.Idugovora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaA__IDUgo__06CD04F7");

                entity.HasOne(d => d.IdzapNavigation)
                    .WithMany(p => p.ZahtevZaAktivacijuServisa)
                    .HasForeignKey(d => d.Idzap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaA__IDZap__05D8E0BE");
            });

            modelBuilder.Entity<ZahtevZaPodacima>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BrSimkartica)
                    .IsRequired()
                    .HasColumnName("BrSIMKartica")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.Idoperatera).HasColumnName("IDOperatera");

                entity.Property(e => e.Idzahteva)
                    .HasColumnName("IDZahteva")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.HasOne(d => d.IdklijentaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idklijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDKli__4222D4EF");

                entity.HasOne(d => d.IdoperateraNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idoperatera)
                    .HasConstraintName("FK__ZahtevZaP__IDOpe__4316F928");

                entity.HasOne(d => d.IdzapNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Idzap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__412EB0B6");
            });

            modelBuilder.Entity<ZahtevZaPomocPriInstalacijiThusluge>(entity =>
            {
                entity.HasKey(e => e.Idzahteva)
                    .HasName("PK__ZahtevZa__8A6BB9D0686162EB");

                entity.ToTable("ZahtevZaPomocPriInstalacijiTHUsluge");

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.DatumSlanja).HasColumnType("date");

                entity.Property(e => e.Idugovora).HasColumnName("IDUgovora");

                entity.Property(e => e.Idzaposlenog).HasColumnName("IDZaposlenog");

                entity.Property(e => e.Termin).HasColumnType("date");

                entity.HasOne(d => d.IdugovoraNavigation)
                    .WithMany(p => p.ZahtevZaPomocPriInstalacijiThusluge)
                    .HasForeignKey(d => d.Idugovora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDUgo__32AB8735");

                entity.HasOne(d => d.IdzaposlenogNavigation)
                    .WithMany(p => p.ZahtevZaPomocPriInstalacijiThusluge)
                    .HasForeignKey(d => d.Idzaposlenog)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__31B762FC");
            });

            modelBuilder.Entity<ZahtevZaProveruKreditneSposobnosti>(entity =>
            {
                entity.HasKey(e => e.Idzahteva)
                    .HasName("PK__ZahtevZa__8A6BB9D020368456");

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.Datum).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.Idkr).HasColumnName("IDKr");

                entity.Property(e => e.Idtr).HasColumnName("IDTR");

                entity.Property(e => e.IdzapP).HasColumnName("IDZapP");

                entity.Property(e => e.IdzapS).HasColumnName("IDZapS");

                entity.Property(e => e.NacinDostave)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdtrNavigation)
                    .WithMany(p => p.ZahtevZaProveruKreditneSposobnosti)
                    .HasForeignKey(d => d.Idtr)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaPr__IDTR__5165187F");

                entity.HasOne(d => d.IdzapPNavigation)
                    .WithMany(p => p.ZahtevZaProveruKreditneSposobnostiIdzapPNavigation)
                    .HasForeignKey(d => d.IdzapP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__534D60F1");

                entity.HasOne(d => d.IdzapSNavigation)
                    .WithMany(p => p.ZahtevZaProveruKreditneSposobnostiIdzapSNavigation)
                    .HasForeignKey(d => d.IdzapS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__52593CB8");

                entity.HasOne(d => d.Kredit)
                    .WithMany(p => p.ZahtevZaProveruKreditneSposobnosti)
                    .HasForeignKey(d => new { d.Idkr, d.SifraVrsteKr, d.Idklijenta })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaProveruK__5441852A");
            });

            modelBuilder.Entity<ZahtevZaProveruTehnickihUsluga>(entity =>
            {
                entity.HasKey(e => e.Idzahteva)
                    .HasName("PK__ZahtevZa__8A6BB9D0C8D19433");

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.IdzapP).HasColumnName("IDZapP");

                entity.Property(e => e.IdzapS).HasColumnName("IDZapS");

                entity.HasOne(d => d.IdzapPNavigation)
                    .WithMany(p => p.ZahtevZaProveruTehnickihUslugaIdzapPNavigation)
                    .HasForeignKey(d => d.IdzapP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__6A30C649");

                entity.HasOne(d => d.IdzapSNavigation)
                    .WithMany(p => p.ZahtevZaProveruTehnickihUslugaIdzapSNavigation)
                    .HasForeignKey(d => d.IdzapS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaP__IDZap__693CA210");
            });

            modelBuilder.Entity<ZahtevZaTehnickomPodrskom>(entity =>
            {
                entity.HasKey(e => e.IdzahtevaTp)
                    .HasName("PK__ZahtevZa__1C06B8864BA31F4C");

                entity.Property(e => e.IdzahtevaTp).HasColumnName("IDZahtevaTP");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idugovora).HasColumnName("IDUgovora");

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.HasOne(d => d.IdugovoraNavigation)
                    .WithMany(p => p.ZahtevZaTehnickomPodrskom)
                    .HasForeignKey(d => d.Idugovora)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaT__IDUgo__0E6E26BF");

                entity.HasOne(d => d.IdzapNavigation)
                    .WithMany(p => p.ZahtevZaTehnickomPodrskom)
                    .HasForeignKey(d => d.Idzap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaT__IDZap__0D7A0286");
            });

            modelBuilder.Entity<ZahtevZaThuslugom>(entity =>
            {
                entity.HasKey(e => e.Idzahteva)
                    .HasName("PK__ZahtevZa__8A6BB9D057611C59");

                entity.ToTable("ZahtevZaTHUslugom");

                entity.Property(e => e.Idzahteva).HasColumnName("IDZahteva");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Idklijenta).HasColumnName("IDKlijenta");

                entity.Property(e => e.IdzapP).HasColumnName("IDZapP");

                entity.Property(e => e.IdzapS).HasColumnName("IDZapS");

                entity.HasOne(d => d.IdklijentaNavigation)
                    .WithMany(p => p.ZahtevZaThuslugom)
                    .HasForeignKey(d => d.Idklijenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaT__IDKli__18EBB532");

                entity.HasOne(d => d.IdzapPNavigation)
                    .WithMany(p => p.ZahtevZaThuslugomIdzapPNavigation)
                    .HasForeignKey(d => d.IdzapP)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaT__IDZap__17F790F9");

                entity.HasOne(d => d.IdzapSNavigation)
                    .WithMany(p => p.ZahtevZaThuslugomIdzapSNavigation)
                    .HasForeignKey(d => d.IdzapS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ZahtevZaT__IDZap__17036CC0");
            });

            modelBuilder.Entity<Zaposleni>(entity =>
            {
                entity.HasKey(e => e.Idzap)
                    .HasName("PK__Zaposlen__893338573A068971");

                entity.Property(e => e.Idzap).HasColumnName("IDZap");

                entity.Property(e => e.DatumUvodjenja)
                    .HasColumnName("datumUvodjenja")
                    .HasColumnType("date");

                entity.Property(e => e.Idpoz).HasColumnName("IDPoz");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdpozNavigation)
                    .WithMany(p => p.Zaposleni)
                    .HasForeignKey(d => d.Idpoz)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Zaposleni__IDPoz__2B3F6F97");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
