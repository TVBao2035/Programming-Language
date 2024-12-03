
            return begin;
        }
        void setEnd(Point end){
            this->end = end;
        }
        Point getEnd(){
            return end;
        }
        double getLength(){
            return sqrt(pow(end.getX()-begin.getX(),2)+pow(end.getY()-begin.getY(),2));
        }
};