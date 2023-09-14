public class Student
{
	private string name;
	private float grade;
	public Student()
	{
	}
	public Student(string name, float grade)
	{
		this.name = name;
		this.grade = grade;
	}
	public void setName(string name)
	{
		this.name = name;
	}
	public string getName()
	{
		return this.name;
	}
	public void setGrade(float grade)
	{
		this.grade = grade;
	}
	public float getGrade()
	{
		return this.grade;
	}
	public string toString()
	{
		return string.Format("Name: {0} - Grade: {1}", this.name,this.grade);
	}
}