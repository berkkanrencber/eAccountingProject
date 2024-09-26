import { CompanyUserModel } from "./company-user.model";
import { CompanyModel } from "./company.model";

export class UserModel{
    id: string = "";
    name: string = "";
    firstName: string ="";
    lastName: string = "";
    password: string | null= "";
    userName: string = "";
    email: string = "";
    fullName: string ="";
    companyId: string = "";
    companyIds: string[]= [];
    companyUsers: CompanyUserModel[] = [];
    companies: CompanyModel[] = [];
}