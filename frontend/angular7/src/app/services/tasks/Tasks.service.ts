import { environment } from './../../../environments/environment.prod';
import { TaskModel } from 'src/app/models/tasks/Task.model';

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError, of } from 'rxjs';
import { map, catchError } from 'rxjs/operators';


const API_Get_TaskList = environment.apiEndpoint + 'tasks';
const API_Get_Task = environment.apiEndpoint;
const API_Save_Task = environment.apiEndpoint + 'tasks';
const API_Done_Task = environment.apiEndpoint + 'tasks/done/';

@Injectable()
export class TasksService {
    constructor(private _http: HttpClient){}

    getList(): Observable<TaskModel[]> {
        return this._http.get<TaskModel[]>(API_Get_TaskList).pipe(
            map((res:TaskModel[])=>{ return res.map(r => new TaskModel().deserialize(r))}),
            catchError(error => throwError(error))
        );
    }

    getTask(taskId: number): Observable<TaskModel> | Promise<TaskModel> | TaskModel {
        return this,this._http.get<TaskModel>(API_Get_Task + `${taskId}`).pipe(
            map((res:TaskModel)=>{ return new TaskModel().deserialize(res)}),
            catchError(error => throwError(error))
        );
    }

    saveTask(task: TaskModel): Observable<TaskModel> {
        if(0 === task.id) {
            return this.insertTask(task);
        } else {
            return this.updateTask(task);
        }
    }

    private insertTask(task: TaskModel): Observable<TaskModel> {
        return this._http.post<TaskModel>(API_Save_Task, task).pipe(
            map((res: TaskModel)=>{ return new TaskModel().deserialize(res)}),
            catchError(error => throwError(error))
        );
    }

    private updateTask(task: TaskModel): Observable<TaskModel> {
        return this._http.put(API_Save_Task, task).pipe(
            map((res: TaskModel)=>{ return new TaskModel().deserialize(res)}),
            catchError(error => throwError(error))
        );
    }

    setState(taskId: number, done: boolean): Observable<boolean>{
        const data = {
            done: done 
        };
        console.log('yahoo');
        return this._http.post(API_Done_Task + `${taskId}`, data).pipe(
            map(r=>{return true;}),
            catchError(error => throwError(error))
        );
    }
}