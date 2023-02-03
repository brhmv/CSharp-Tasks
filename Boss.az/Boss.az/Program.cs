using Boss.az;

List<Worker> Workers = new();

List<Employer> Employers = new();

List<Vacancy> AllVacancies = new();

void FillListWithAllVacancies()
{
    foreach (var item in Employers)
    {
        foreach (var item1 in item.Vacancies)
        {
            AllVacancies.Add(item1);
        }
    }
}


void apply(string title,string content,Worker worker)
{
    int id;
    Console.WriteLine("Id:");
    id = Convert.ToInt32(Console.ReadLine());

    foreach (var item in Employers)
    {
        foreach (var vacancy in item.Vacancies)
        {
            if (vacancy.ObjectId == id)
            {
                //item.Notifications.Where(n => n.Vacancy == vacancy);
                item.Notifications.Add(new Notification(title, content, worker, vacancy));
            }
        }
    }
}

#region Test

Employer e1 = new("ali", "aliyev", 42, "055", "baku");
Employer e2 = new("akif", "Alziade", 23, "050", "baku");
Employer e3 = new("Aqil", "Agazade", 13, "070", "baku");

Vacancy v11 = new("it1", "a", 123, 4, 45, Worktype.Parttime);
v11.FromWhichEmployer = e1;

Vacancy v12 = new("it1", "a", 123, 4, 45, Worktype.Parttime);
v12.FromWhichEmployer = e1;

Vacancy v21 = new("it2", "a", 123, 4, 45, Worktype.Parttime);
v21.FromWhichEmployer = e2;

Vacancy v22 = new("it2", "a", 123, 4, 45, Worktype.Parttime);
v22.FromWhichEmployer = e2;

Vacancy v31 = new("it3", "a", 123, 4, 45, Worktype.Parttime);
v31.FromWhichEmployer = e3;

Vacancy v32 = new("it3", "a", 123, 4, 45, Worktype.Parttime);
v32.FromWhichEmployer = e3;

Employers.Add(e1);
Employers.Add(e2);
Employers.Add(e3);

e1.AddVacancy(v12);
e1.AddVacancy(v11);
e2.AddVacancy(v22);
e2.AddVacancy(v21);
e3.AddVacancy(v31);
e3.AddVacancy(v32);

List<Vacancy> vs1 = new();
List<Vacancy> vs2 = new();
List<Vacancy> vs3 = new();

vs1.Add(v12);
vs1.Add(v11);
vs2.Add(v21);
vs2.Add(v22);
vs3.Add(v31);
vs3.Add(v32);

e1.Vacancies = vs1;
e2.Vacancies = vs2;
e3.Vacancies = vs3;

#endregion

Console.WriteLine("s");

foreach (var item in Employers)
{
    foreach (var item1 in item.Vacancies)
    {
        Console.WriteLine(item1.ObjectId);
    }
}






//Employer e = new("a", "b", 4, "ds", "d");
//e.AddVacancy(Vacancy.CreateVacancy());
//e.ShowVacancies();





//filter delegate list yeni her filterden sonra
//sign in
//apply vacancies
