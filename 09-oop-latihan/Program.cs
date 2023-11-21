/*
Latihan: Sistem Pendaftaran Pelajar dengan Kelas dan Objek di C#

Buat sistem pendaftaran pelajar untuk sebuah lembaga pendidikan menggunakan C#.
Sistem ini harus menggunakan konsep kelas dan objek.
Berikut adalah spesifikasi yang diperlukan:

1. Kelas Student
   Kelas ini harus memiliki properti seperti Name, Age, ID, dan Course.
   Selain itu, harus ada metode untuk menampilkan detail pelajar.

2. Kelas Course
   Kelas ini harus memiliki properti seperti CourseName dan CourseCode.
   Kelas ini juga harus bisa menampilkan detail kursus.

3. Implementasi dan Testing
   Buat objek dari kelas Student dan Course, atur nilai propertinya.
   Tunjukkan bagaimana objek-objek ini dapat digunakan untuk menampilkan informasi terkait pelajar dan kursus.
*/

class Program
{
    public static void Main(string[] args)
    {
        Course mathematics = new(id: Guid.NewGuid(), name: "Mathematics", code: "MAT");
        Console.WriteLine(mathematics);

        Course biology = new(id: Guid.NewGuid(), name: "Biology", code: "BIO");
        Console.WriteLine(biology);

        Course chemistry = new(id: Guid.NewGuid(), name: "Chemistry", code: "CHE");
        Console.WriteLine(chemistry);

        Student student1 = new(id: Guid.NewGuid(), name: "Budi", age: 25);

        Course[] courses = [mathematics, biology, chemistry];

        student1.Courses = courses;
        Console.WriteLine(student1);
    }
}
