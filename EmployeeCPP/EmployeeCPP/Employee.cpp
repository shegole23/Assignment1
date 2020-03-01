#include "Employee.h"
#include <iostream>
using namespace std;
namespace EmployeesApp {
	Employee::Employee(const std::string& firstName,
		const std::string& lastName) :
		mFirstName(firstName), mLastName(lastName)
	{ }

	void Employee::setFirstName(const std::string& firstName) {
		mFirstName = firstName;
	}

	const std::string& Employee::getFirstName() const {
		return mFirstName;
	}

	void Employee::setLastName(const std::string& lastName) {
		mLastName = lastName;
	}

	const std::string& Employee::getLastName() const {
		return mLastName;
	}

	void setEmployeeNumber(int employeeNumber) {
		employeeNumber = employeeNumber;
	}

	int Employee::getEmployeeNumber() const {

		return mEmployeeNumber;
	}
	void Employee::display() const {

		cout << "Employee: " << getEmployeeNumber() << ": "
			<< getLastName() << ", " << getFirstName() << endl;
	}
}

