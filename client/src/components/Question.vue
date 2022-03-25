<template>
  <div class="question">
    <div class="question__summary">
      <span class="question__votes">0 votes</span>
      <span class="question__answer">1 answer</span>
      <span class="question__shows">10 views</span>
    </div>
    <div class="question__content">
      <h2 class="question__title">
        <a href="#">Some sample title of question</a>
      </h2>
      <p class="question__desc">
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Vero, similique molestiae odio necessitatibus quasi consequatur architecto veritatis modi, harum nemo quas sed omnis error. Tempore nesciunt explicabo optio quas! Voluptatum?
      </p>
      <p class="question__meta">
        <span class="question__meta-tags">
        <tag 
          class="question__tag"
          v-for="item in Math.ceil(Math.random()* 5)" 
          :key="item" 
          :tag="'short tag'"
        />
        </span>
        <span class="question__meta-user">
          <avatar class="question__meta-avatar"/>
          <a href="#" class="link">Andrew</a>
          <span class="question__rep">18k</span>
          <span class="question__time">changed 3 hours ago</span>
        </span>
      </p>
    </div>
  </div>
</template>

<script>
import Avatar from "@/components/Avatar"
import Tag from "@/components/Tag"
export default {
  name: "Question",
  components: {
    Avatar,
    Tag
  }
};
</script>

<style scoped lang="scss">
.question {
  width: 100%;
  border-bottom: 1px solid var(--black200);
  padding: 16px;
  display: flex;
  &:first-child {
    border-top: 1px solid var(--black200);
  }
  &:last-child {
    border: none;
  }
  &__summary {
    width: 108px;
    min-width: 108px;
    display: flex;
    flex-direction: column;
    align-items: flex-end;
    text-align: right;
    margin-right: 1rem;
  }
  &__votes {
    color: var(--black900);
    margin-bottom: 5px;
  }
  &__answer {
    color: var(--green600);
    border-radius: 5px;
    width: fit-content;
    border: 1px solid var(--green600);
    padding: 2px 3px;
    margin-bottom: 5px;
  }
  &__desc {
    color: var(--black700);
  }
  &__shows {
    color: var(--black900);
  }
  &__title {
    margin: 0;
    font-size: 17px;
    font-weight: 500;
    padding: 0;
    a {
      text-decoration: none;
      color: var(--blue600);
    }
  }
  &__tag {
    margin-right: 3px;
  }
  &__content {
    display: flex;
    flex-direction: column;
    flex-grow: 1;
  }
  &__meta {
    display: flex;
    justify-content: space-between;
    flex-wrap: wrap;
  }
  &__meta-tags {
    display: flex;
    align-items: center;
    flex-wrap: wrap;
  }
  &__meta-user {
    display: flex;
    align-items: center;
  }
  &__meta-avatar {
    margin-right: 1rem;
  }
  &__rep {
    color: var(--black900);
    margin-right: 1rem;
  }
  &__time {
    color: var(--black500);
  }
}
.link {
  margin-right: 5px;
}
</style>
