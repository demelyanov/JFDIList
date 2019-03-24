import { IDeserializable } from '../IDeserializable';
import { __assign } from 'tslib';

export interface ITaskModel {
    id: number;
    task: string;
    taskDate?: Date;
    createdDate: Date;
}

export class TaskModel implements ITaskModel, IDeserializable<TaskModel> {
    id: number;
    task: string;
    taskDate?: Date;
    createdDate: Date;

    deserialize(input: any): TaskModel {
        Object.assign(this, input);
        return this;
    }

}