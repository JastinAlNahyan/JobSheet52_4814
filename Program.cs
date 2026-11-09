Console.Write("Masukkan nama pelanggan : ");
string NamaPelanggan = Console.ReadLine()!;

Console.Write("Nama Dokumen : ");
string namaDokumen = Console.ReadLine()!;

Console.Write("Masukkan Jumlah Halaman : ");
int JumlahHalaman = int.Parse(Console.ReadLine()!);

Console.Write("Masukkan Harga Per Halaman : ");
int HargaPerHalaman = int.Parse(Console.ReadLine()!);

const int BiayaAdministrasi = 2000;

int subtotal = JumlahHalaman * HargaPerHalaman;
int totalbiaya = subtotal + BiayaAdministrasi;

Console.WriteLine($"Nama Pelanggan = {NamaPelanggan}");
Console.WriteLine($"Jumlah Halaman = {JumlahHalaman}");
Console.WriteLine($"Nama Dokumen = {namaDokumen}");
Console.WriteLine($"Harga Perhalaman = {HargaPerHalaman}");
Console.WriteLine($"SubTotal = {subtotal}");
Console.WriteLine($"Biaya Admin = {BiayaAdministrasi}");
Console.WriteLine($"TotalBiaya = {totalbiaya}");